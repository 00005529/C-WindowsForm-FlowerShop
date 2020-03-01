using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
  public class Bouquet
    {
        public Bouquet()
        {
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public List<BouquetPartTemp> UsedFlowersList { get; set; }
        public int PriceOfBouquet
        {
            get
            {
                return getPrice();
            }
        }


        public int getPrice()
        {
            int Price = 0;
            if (UsedFlowersList.Count() > 0)
            {
                foreach (BouquetPartTemp flw in this.UsedFlowersList)
                {
                    Price += flw.PriceOfBouquetPart;
                }

            }

            return Price;
        }



    }
}
