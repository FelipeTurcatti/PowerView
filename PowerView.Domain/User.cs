using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class User
    {
        public Int32 UserId { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }   
        public DateTime CreationDate { get; set; } 
        public String TelephoneNumber { get; set; }

    }
}
