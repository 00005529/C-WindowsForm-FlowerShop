using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
    public class Vendor:User
    {
        public override string GetUserType()
        {
            return "Vendor";
        }
    }
}
