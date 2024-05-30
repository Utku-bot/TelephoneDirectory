using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Entities
{
    public class PhoneDirectory
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumberI { get; set; }
        public string phoneNumberII { get; set; }
        public string phoneNumberIII { get; set; }
        public string emailAddress { get; set; }
        public string webAddress { get; set; }
        public string address { get; set; }
        public string description { get; set; }

    }
}
