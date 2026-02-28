using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchedulingApp.Utilities
{
    public static class LoginHistory
    {
        private static readonly string FileName = "Login_History.txt";

        public static void Append(string username)
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {username}";
            File.AppendAllText(FileName, line + Environment.NewLine);
        }
    }
}
