using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
     public class Sale
    {
        public Sale()
        {
            this.SoldDate = DateTime.Now;
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public User Customer { get; set; }
        public string CustomerName { get { return Customer.FirstName + " " + Customer.LastName; } }
        public Bouquet Bouquet { get; set; }
        public string FlowersUsed { get { return getListofFlowers(); } }
        public int Price { get {return Bouquet.PriceOfBouquet; } }
        public DateTime SoldDate { get; set; }
        public string getListofFlowers()
        {
            string flowers = "";
            foreach(BouquetPartTemp b in Bouquet.UsedFlowersList)
            {
               flowers+= b.UsedFlowerTemp.Description + " " + b.UsedFlowerTemp.Color +" "+b.quantityOfUserFlower+", ";
            }
            return flowers;
        }
    }
}
