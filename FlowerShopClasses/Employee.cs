using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
    public class Employee : User
    {
        public string Position { get; set; }
        public DateTime getHired { get; set; }
        public override string GetUserType()
        {
            return "Employee";
        }
    }
}
