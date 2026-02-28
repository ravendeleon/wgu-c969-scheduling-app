using SchedulingApp.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchedulingApp.Models;
using MySql.Data.MySqlClient;

namespace SchedulingApp
{
    public partial class AddCustomerForm : Form
    {
        private readonly string _username;
        private Models.Customer _customerToEdit;

        public AddCustomerForm(string username)   // adding customer
        {
            InitializeComponent();
            _username = username;
            _customerToEdit = null;
        }

        public AddCustomerForm(string username, Models.Customer customer)   // editing customer
        {
            InitializeComponent();
            _username = username;
            _customerToEdit = customer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = (txtName.Text ?? "").Trim();
            string address = (txtAddress.Text ?? "").Trim();
            string phone = (txtPhone.Text ?? "").Trim();
            string postal = (txtPostal.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(postal))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && c != '-')
                {
                    MessageBox.Show("Phone number must contain only digits and dashes.");
                    return;
                }
            }

            if (cmbCity.SelectedValue == null)
            {
                MessageBox.Show("Please select a city.");
                return;
            }

            int cityId = Convert.ToInt32(cmbCity.SelectedValue);

            // exception handling
            try
            {
                DatabaseConnection.OpenConnection();

                if (_customerToEdit == null)
                {
                    CustomerRepository.AddCustomer(name, address, phone, postal, cityId, _username);
                }
                else
                {
                    CustomerRepository.UpdateCustomer(
                        _customerToEdit.CustomerId,
                        name,
                        address,
                        phone,
                        postal,
                        cityId,
                        _username);
                }

                MessageBox.Show("Customer added successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add customer:\n" + ex.Message,
                    "Adding Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            LoadCities();

            if (_customerToEdit != null)
            {
                txtName.Text = _customerToEdit.CustomerName;
                txtAddress.Text = _customerToEdit.Address;
                txtPhone.Text = _customerToEdit.Phone;
            }
        }

        private void LoadCities()
        {
            try
            {
                DatabaseConnection.OpenConnection();

                List<CityInfo> cities = CityRepository.GetAllCities();

                cmbCity.DisplayMember = "DisplayName";
                cmbCity.ValueMember = "CityId";
                cmbCity.DataSource = cities;

                if (cmbCity.Items.Count > 0)
                    cmbCity.SelectedIndex = 0;
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }
    }
}
