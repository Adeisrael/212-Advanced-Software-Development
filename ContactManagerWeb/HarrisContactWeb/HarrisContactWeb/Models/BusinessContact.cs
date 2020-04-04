using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Models
{
    public class BusinessContact
    {//Attributes of BusinessContact Class
        public int BusinessContactID { get; set; }//Primary key for Business Contacts
        public string BusinessFname { get; set; }//String Business Contact Firstname
        public string BusinessLname { get; set; }//String Business Contact Lastname 
        public string BusinessEmail { get; set; }//String Business Contact Email
        public string BusinessTel { get; set; }//String Business Contact Telephone
        public string BusinessAdrr1 { get; set; }//String Business Contact Address 1
        public string BusinessAddr2 { get; set; }//String Business Contact Address 2
        public string BusinessCity { get; set; }//String Business Contact City
        public string BuisnessPostCode { get; set; }//String Business Contact Postcode

    }
}
