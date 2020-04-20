using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisandSonsContactWeb.Models
{
    public class BusinessContact
    {
        public int BusinessContactID { get; set; }
        public string BusinessFname { get; set; }
        public string BusinessLname { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessAddress1 { get; set; }
        public string BusinessAddress2 { get; set; }
        public string BusinessCity { get; set; }
        public string BusinessPostCode { get; set; }
        public string BusinessTel { get; set; }
    }
}
