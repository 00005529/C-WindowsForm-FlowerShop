using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
    public abstract class User
    {

        public User()
        {
        }
     
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PassportNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
        public string UserType { get { return GetUserType(); } }
        public abstract string GetUserType();
    }
}
 
