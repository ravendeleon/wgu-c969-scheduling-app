using SchedulingApp.Access;
using SchedulingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class MainForm : Form
    {
        private readonly string _username;

        public MainForm(string username)
        {
            InitializeComponent();
            StyleGrid();

            _username = username;
            Text = $"Main - Logged in as {_username}";

            try
            {
                DatabaseConnection.OpenConnection();
                LoadCustomers();
                LoadAppointments();
                LoadCalendarDay(DateTime.Today);
                calAppointments.SetDate(DateTime.Today);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }

        }

        private void StyleGrid()
        {
            dgvReports.AutoGenerateColumns = true;
            dgvCustomers.AutoGenerateColumns = true;
            dgvAppointments.AutoGenerateColumns = true;
            dgvCalendar.AutoGenerateColumns = true;
        }

        private void LoadCustomers()
        {
            var customers = CustomerRepository.GetAllCustomers();
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.DataSource = customers;
            dgvCustomers.ClearSelection();
        }

        private void LoadAppointments()
        {
            var appts = AppointmentRepository.GetAllAppointments();
            dgvAppointments.AutoGenerateColumns = true;
            dgvAppointments.DataSource = appts;
            dgvAppointments.ClearSelection();

            // formatting the columns to show 12-hour time and date format
            dgvAppointments.Columns["StartLocal"].DefaultCellStyle.Format = "M/d/yyyy h:mm tt";
            dgvAppointments.Columns["EndLocal"].DefaultCellStyle.Format = "M/d/yyyy h:mm tt";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (AddCustomerForm form = new AddCustomerForm(_username))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }

        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to modify.");
                return;
            }

            var selectedCustomer = (SchedulingApp.Models.Customer)dgvCustomers.CurrentRow.DataBoundItem;

            using (AddCustomerForm form = new AddCustomerForm(_username, selectedCustomer))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            var selectedCustomer = (SchedulingApp.Models.Customer)dgvCustomers.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                DatabaseConnection.OpenConnection();

                if (CustomerRepository.CustomerHasAppointments(selectedCustomer.CustomerId))
                {
                    MessageBox.Show("This customer has appointments and cannot be deleted.",
                        "Delete Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CustomerRepository.DeleteCustomer(selectedCustomer.CustomerId);
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete customer:\n" + ex.Message);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            using (AppointmentForm form = new AppointmentForm(_username))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DatabaseConnection.OpenConnection();
                        LoadAppointments();
                    }
                    finally
                    {
                        DatabaseConnection.CloseConnection();
                    }
                }
            }
        }

        private void btnModifyAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to modify.");
                return;
            }

            var selectedAppt = (SchedulingApp.Models.Appointment)dgvAppointments.CurrentRow.DataBoundItem;

            using (AppointmentForm form = new AppointmentForm(_username, selectedAppt.AppointmentId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DatabaseConnection.OpenConnection();
                        LoadAppointments();
                    }
                    finally
                    {
                        DatabaseConnection.CloseConnection();
                    }
                }
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            var selectedAppt = (SchedulingApp.Models.Appointment)dgvAppointments.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                DatabaseConnection.OpenConnection();
                AppointmentRepository.DeleteAppointment(selectedAppt.AppointmentId);
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete appointment:\n" + ex.Message);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnExitAppointment_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calAppointments_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();
                LoadCalendarDay(e.Start);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void LoadCalendarDay(DateTime selectedLocalDate)
        {
            var appts = AppointmentRepository.GetAppointmentsForLocalDay(selectedLocalDate);

            dgvCalendar.AutoGenerateColumns = true;
            dgvCalendar.DataSource = appts;
            dgvCalendar.ClearSelection();

            if (dgvCalendar.Columns["StartLocal"] != null)
                dgvCalendar.Columns["StartLocal"].DefaultCellStyle.Format = "M/d/yyyy h:mm tt";
            if (dgvCalendar.Columns["EndLocal"] != null)
                dgvCalendar.Columns["EndLocal"].DefaultCellStyle.Format = "M/d/yyyy h:mm tt";
        }

        private void btnReportTypesByMonth_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                var appts = AppointmentRepository.GetAllAppointmentsForReports();

                // using Lambda expressions + collections
                var report = appts
                    .GroupBy(a => new { Month = a.StartLocal.ToString("yyyy-MM"), a.Type })
                    .Select(g => new TypeByMonthRow
                    {
                        Month = g.Key.Month,
                        Type = g.Key.Type,
                        Count = g.Count()
                    })
                    .OrderBy(r => r.Month)
                    .ThenBy(r => r.Type)
                    .ToList();

                dgvReports.AutoGenerateColumns = true;
                dgvReports.DataSource = report;
                dgvReports.ClearSelection();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }

            lblReportTitle.Text = "Report: Appointment Types by Month";

        }

        private void btnReportScheduleByUser_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                var data = AppointmentRepository.GetAppointmentsWithUserNames();

                var report = data
                    .Select(x => new UserScheduleRow
                    {
                        UserName = x.UserName,
                        AppointmentId = x.Appt.AppointmentId,
                        CustomerName = x.Appt.CustomerName,
                        Type = x.Appt.Type,
                        StartLocal = x.Appt.StartLocal,
                        EndLocal = x.Appt.EndLocal
                    })
                    .OrderBy(r => r.UserName)
                    .ThenBy(r => r.StartLocal)
                    .ToList();

                dgvReports.AutoGenerateColumns = true;
                dgvReports.DataSource = report;
                dgvReports.ClearSelection();

                if (dgvReports.Columns["StartLocal"] != null)
                    dgvReports.Columns["StartLocal"].DefaultCellStyle.Format = "M/d/yyyy h:mm tt";
                if (dgvReports.Columns["EndLocal"] != null)
                    dgvReports.Columns["EndLocal"].DefaultCellStyle.Format = "M/d/yyyy h:mm tt";
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }

            lblReportTitle.Text = "Report: Schedule by User";
        }

        private void btnReportCustom_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();

                var appts = AppointmentRepository.GetAllAppointmentsForReports();

                var report = appts
                    .GroupBy(a => a.CustomerName)
                    .Select(g => new CustomerAppointmentCountRow
                    {
                        CustomerName = g.Key,
                        Count = g.Count()
                    })
                    .OrderByDescending(r => r.Count)
                    .ThenBy(r => r.CustomerName)
                    .ToList();

                dgvReports.AutoGenerateColumns = true;
                dgvReports.DataSource = report;
                dgvReports.ClearSelection();
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }

            lblReportTitle.Text = "Report: Number of Appointments by Customer";
        }
    }
}
