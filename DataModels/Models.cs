using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Hospital
    {
        public int status = -1;
        public int HospitalId { get; set; }
        public int UserId { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public int IsPrimary { get; set; }
    }
}
