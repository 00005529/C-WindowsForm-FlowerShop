using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
  public class BouquetPartTemp
    {
        public BouquetPartTemp()
        {

        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Flower UsedFlowerTemp { get; set; }
        public string FlowerDesc { get { return UsedFlowerTemp.Description; } }
        public int quantityOfUserFlower { get; set; }
        public int PriceOfBouquetPart
        {
            get
            {
                return UsedFlowerTemp.Price * quantityOfUserFlower;
            }
        }
    }
}
