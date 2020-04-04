using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Models
{
    public class PersonalContact
    {// Attributes of the Personal Contact
        public int PersonalContactID { get; set; }//Primary Key of Personal Contact
        public string PersonalFname { get; set; }//String Personal Contact Firstname
        public string PersonsalLname { get; set; }//String Personal Contact Lastname 
        public string PersonalEmail { get; set; }//String Personal Contact Email
        public string HomeTel { get; set; }//String Personal Contact Home Telephone
        public string PersonalAddr1 { get; set; }//String Personal Contact Address 1
        public string PersonalAddr2 { get; set; }//String Personal Contact Address 2
        public string PersonalCity { get; set; }//String Personal Contact City 
        public string PersonalPostCode { get; set; }//String Personal Contact PostCode

    }
}
