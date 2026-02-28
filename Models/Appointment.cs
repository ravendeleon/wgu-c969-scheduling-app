using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Type { get; set; }

        // displaying local times in the UI
        public System.DateTime StartLocal { get; set; }
        public System.DateTime EndLocal { get; set; }
        public int UserId { get; set; }
    }
}
