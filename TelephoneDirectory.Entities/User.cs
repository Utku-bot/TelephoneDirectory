using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory.Entities
{
   public class User
    {
        public Guid userID { get; set; }
        public string userName { get; set; }
        
        public string password { get; set; }
    }
}
