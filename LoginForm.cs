using SchedulingApp.Access;
using SchedulingApp.Properties;
using SchedulingApp.Resources;
using SchedulingApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


            ApplyLocalizedText();
            ShowLocation();

            btnLogin.Cursor = Cursors.Hand;
            btnExit.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = (txtUsername.Text ?? "").Trim();
            string password = (txtPassword.Text ?? "").Trim();

            try
            {
                DatabaseConnection.OpenConnection();

                bool valid = UserRepository.ValidateLogin(username, password);

                // record timestamp + username
                LoginHistory.Append(username);

                if (!valid)
                {
                    MessageBox.Show(StringResources.InvalidCredentials, StringResources.LoginErrorTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AppointmentAlerts.ShowUpcoming(username);


                Hide();
                MainForm main = new MainForm(username);
                main.FormClosed += (s, args) => Close();
                main.Show();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ApplyLocalizedText()
        {
            Text = StringResources.LoginTitle;
            lblUsername.Text = StringResources.Username;
            lblPassword.Text = StringResources.Password;
            btnLogin.Text = StringResources.LoginButton;
            btnExit.Text = StringResources.ExitButton;
        }

        private void ShowLocation()
        {
            string loc = Localization.GetLocationSummary();
            lblLocation.Text = string.Format(StringResources.LocationLabel, loc);
        }
    }
}