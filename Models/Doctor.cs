using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Department { get; set; }

        public string AvailableTime { get; set; }

        public string PhotoFileName { get; set; }
    }
}
