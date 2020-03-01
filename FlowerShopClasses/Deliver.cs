using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
  public  class Deliver
    {
        public Deliver()
        {
            this.DeliveredDate =DateTime.Now;
        }
        public Flower DeliveredFlower { get; set; }
        public string FlowerName { get { return DeliveredFlower.Description+" " + DeliveredFlower.Color; } }
        public int quantityDelivered { get; set; }
        public User Vendor { get; set; }
        public string VendorName { get { return Vendor.FirstName + " " + Vendor.LastName; } }
        public DateTime DeliveredDate { get; set; }
        public User RecievedEmployee { get; set; }
        public string EmployeeName { get {return RecievedEmployee.FirstName; } }
    }
}
