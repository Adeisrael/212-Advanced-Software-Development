using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerCSharp
{
    public abstract class Contact
    {
        public int ContactID { get; set; }
        public string ContactFname { get; set; }
        public string ContactLname { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTel { get; set; }
        public string ContactAddr1 { get; set; }
        public string ContactAddr2 { get; set; }
        public string ContactCity { get; set; }
        public string ContactPostcode { get; set; }
    }
}
