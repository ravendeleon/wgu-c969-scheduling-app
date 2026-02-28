using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchedulingApp.Access;

namespace SchedulingApp.Utilities
{
    public static class AppointmentAlerts
    {
        public static void ShowUpcoming(string username)
        {
            int userId = UserRepository.GetUserId(username);
            if (userId <= 0) return;

            DateTime utcNow = DateTime.UtcNow;
            DateTime utcIn15 = utcNow.AddMinutes(15);

            int apptId;
            DateTime startUtc;

            bool found = AppointmentRepository.TryGetUpcomingAppointment(userId, utcNow, utcIn15, out apptId, out startUtc);

            if (!found)
            {
                MessageBox.Show("No upcoming appointments within 15 minutes.", "Appointment Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // convert UTC start time to local time for the user
            DateTime localStart = startUtc.ToLocalTime();

            MessageBox.Show(
                $"Upcoming appointment!\n\nID: {apptId}\nStarts: {localStart:yyyy-MM-dd HH:mm}",
                "Appointment Alert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
