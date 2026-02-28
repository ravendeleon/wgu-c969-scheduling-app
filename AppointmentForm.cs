using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchedulingApp.Access;
using SchedulingApp.Models;

namespace SchedulingApp
{
    public partial class AppointmentForm : Form
    {
        private readonly string _username;
        private readonly int? _appointmentId;
        private int _userId;

        public AppointmentForm(string username)
        {
            InitializeComponent();
            _username = username;
            _appointmentId = null;
        }

        public AppointmentForm(string username, int appointmentId)
        {
            InitializeComponent();
            _username = username;
            _appointmentId = appointmentId;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                _userId = UserRepository.GetUserId(_username);

                List<CustomerLookup> customers = CustomerRepository.GetCustomerLookup();
                cmbCustomer.DisplayMember = "CustomerName";
                cmbCustomer.ValueMember = "CustomerId";
                cmbCustomer.DataSource = customers;

                cmbType.Items.Clear();
                cmbType.Items.AddRange(new object[]
                {
                    "Consultation",
                    "Planning",
                    "Review",
                    "Follow-up",
                    "Other"
                });
                cmbType.SelectedIndex = 0;

                dtpDate.Value = DateTime.Today;
                dtpStart.Value = DateTime.Today.AddHours(9);
                dtpEnd.Value = DateTime.Today.AddHours(10);

                if (_appointmentId.HasValue)
                {
                    AppointmentEdit appt = AppointmentRepository.GetAppointmentById(_appointmentId.Value);
                    if (appt == null)
                    {
                        MessageBox.Show("Appointment not found.");
                        Close();
                        return;
                    }

                    DateTime startLocal = appt.StartUtc.ToLocalTime();
                    DateTime endLocal = appt.EndUtc.ToLocalTime();

                    cmbCustomer.SelectedValue = appt.CustomerId;

                    int typeIndex = cmbType.FindStringExact(appt.Type);
                    cmbType.SelectedIndex = typeIndex >= 0 ? typeIndex : 0;

                    dtpDate.Value = startLocal.Date;
                    dtpStart.Value = startLocal;
                    dtpEnd.Value = endLocal;

                    Text = "Modify Appointment";
                }
                else
                {
                    Text = "Add Appointment";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load appointment form:\n" + ex.Message);
                Close();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            string type = (cmbType.SelectedItem ?? "").ToString().Trim();

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please select an appointment type.");
                return;
            }

            // Combine date and times into local DateTime
            DateTime startLocal = dtpDate.Value.Date
                .AddHours(dtpStart.Value.Hour)
                .AddMinutes(dtpStart.Value.Minute);

            DateTime endLocal = dtpDate.Value.Date
                .AddHours(dtpEnd.Value.Hour)
                .AddMinutes(dtpEnd.Value.Minute);

            if (endLocal <= startLocal)
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            DateTime startUtc = DateTime.SpecifyKind(startLocal, DateTimeKind.Local).ToUniversalTime();
            DateTime endUtc = DateTime.SpecifyKind(endLocal, DateTimeKind.Local).ToUniversalTime();

            // business hours validation
            if (!IsWithinBusinessHoursEst(startUtc, endUtc))
            {
                MessageBox.Show("Appointments must be scheduled Mon–Fri, 9:00 AM to 5:00 PM Eastern Time.");
                return;
            }

            try
            {
                DatabaseConnection.OpenConnection();

                bool overlaps = AppointmentRepository.HasOverlappingAppointment(
                    _userId,
                    startUtc,
                    endUtc,
                    _appointmentId);

                if (overlaps)
                {
                    MessageBox.Show("This appointment overlaps with an existing appointment.");
                    return;
                }

                if (_appointmentId.HasValue)
                {
                    AppointmentRepository.UpdateAppointment(_appointmentId.Value, customerId, _userId, type, startUtc, endUtc, _username);
                }
                else
                {
                    AppointmentRepository.AddAppointment(customerId, _userId, type, startUtc, endUtc, _username);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save appointment:\n" + ex.Message,
                    "Appointment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private bool IsWithinBusinessHoursEst(DateTime startUtc, DateTime endUtc)
        {
            TimeZoneInfo eastern;
            try
            {
                eastern = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            }
            catch
            {
                return false;
            }

            DateTime startEst = TimeZoneInfo.ConvertTimeFromUtc(startUtc, eastern);
            DateTime endEst = TimeZoneInfo.ConvertTimeFromUtc(endUtc, eastern);

            if (startEst.DayOfWeek == DayOfWeek.Saturday || startEst.DayOfWeek == DayOfWeek.Sunday)
                return false;

            if (endEst.Date != startEst.Date)
                return false;

            TimeSpan open = new TimeSpan(9, 0, 0);
            TimeSpan close = new TimeSpan(17, 0, 0);

            return startEst.TimeOfDay >= open && endEst.TimeOfDay <= close;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            // Ensure end time is always after start time
            if (dtpEnd.Value <= dtpStart.Value)
                dtpEnd.Value = dtpStart.Value.AddMinutes(15);
        }

    }
}