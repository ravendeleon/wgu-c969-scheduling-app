using SchedulingApp.Access;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                MessageBox.Show("Database connection successful!");
                DatabaseConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
