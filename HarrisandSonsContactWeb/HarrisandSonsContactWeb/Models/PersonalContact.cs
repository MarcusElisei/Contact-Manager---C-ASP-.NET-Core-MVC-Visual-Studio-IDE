using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisandSonsContactWeb.Models
{
    /// <summary>
    /// This class contains the fields needed for the CRUD methods
    /// </summary>
    public class PersonalContact
    {
        public int PersonalContactID { get; set; }
        public string PersonalFame { get; set; }
        public string PersonalLname { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalAddress1 { get; set; }
        public string PersonalAddress2 { get; set; }
        public string PersonalCity { get; set; }
        public string PersonalPostCode { get; set; }
        public string PersonalTel { get; set; }


    }
}
