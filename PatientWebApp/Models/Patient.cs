using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientWebApp.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PFirstName { get; set; }
        public string PLastName { get; set; }

        public Patient()
        {

        }

    }
}
