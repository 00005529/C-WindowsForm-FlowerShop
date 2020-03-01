using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
  public class Flower
    {
        public Flower()
        {

        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description { get; set; }


        public string Color { get; set; }

        public int AvailableQuantity { get; set; }

        public int Price { get; set; }

        public bool isAvailable()
        {
            if(AvailableQuantity>0){
                return true;
            }else{
                return false;
            }
        }

        public DateTime DeliveredDate { get; set; }
    }

}
