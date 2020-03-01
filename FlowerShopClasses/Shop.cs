using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopClasses
{
    public class Shop
    {
        public List<User> Users { get; set; }
        public List<Sale> Orders { get; set; }
        public List<Flower> Flowers { get; set; }
        public List<Flower> AvailableFlowers { get; set; }
        public List<Deliver> Delivers { get; set; }
        public List<Bouquet> Bouquets { get; set; }
        public List<BouquetPartTemp> BouquetPartTemps { get; set; }

        private Shop()
        {
            Users = new List<User>();
            Flowers = new List<Flower>();
            Orders = new List<Sale>();
            AvailableFlowers = new List<Flower>();
            Delivers  = new List<Deliver>();
           
            BouquetPartTemps = new List<BouquetPartTemp>();
            Bouquets = new List<Bouquet>();
        }
        private static Shop sales;
    
        public static Shop GetShop()
        {
            if (sales == null)
            {
                sales = new Shop();
                
                sales.PopulateShopForTest();
                sales.FindAvailableFlowers();
            }
            return sales;
        }

        
        public void FindAvailableFlowers()//the method that populates AvailableFlowers list of Flowers with available flowers
        {
            Shop sl = GetShop();
            
            foreach (Flower flower in Flowers)
            {
                if (flower.AvailableQuantity>0)
                {
                   
                        sl.AvailableFlowers.Add(flower);
                    
                }
            }
            
        }


        public void PopulateShopForTest()
        {
            Shop sl = GetShop();
  

            User usr1 = new Customer() { FirstName = "Aziz", LastName = "Abdullaev", DOB = new DateTime(1996, 2, 2), RegistrationDate = DateTime.Now};
            sl.Users.Add(usr1);
            User usr2 = new Customer() { FirstName = "AbdulAziz", LastName = "Nabijonov", DOB = new DateTime(1996, 3, 3), RegistrationDate = DateTime.Now };
            sl.Users.Add(usr2);
            User usr3 = new Customer() { FirstName = "Asqar", LastName = "Khudoyqulov", DOB = new DateTime(1996, 4, 4), RegistrationDate = DateTime.Now};
            sl.Users.Add(usr3);
            User usr4 = new Customer() { FirstName = "Ahmad", LastName = "Akmalov", DOB = new DateTime(1996, 2, 2), RegistrationDate = DateTime.Now };
            sl.Users.Add(usr4);
            User usr5 = new Customer() { FirstName = "Ibrohim", LastName = "Saydahmatov", DOB = new DateTime(1996, 3, 3), RegistrationDate = DateTime.Now };
            sl.Users.Add(usr5);
            User usr6 = new Customer() { FirstName = "Saidaziz", LastName = "Khojiakbarov", DOB = new DateTime(1996, 4, 4), RegistrationDate = DateTime.Now };
            sl.Users.Add(usr6);
            User usr7 = new Customer() { FirstName = "Saidahmad", LastName = "Khojiakbarov", DOB = new DateTime(1996, 3, 3), RegistrationDate = DateTime.Now };
            sl.Users.Add(usr7);
            User usr8 = new Customer() { FirstName = "Ulugbek", LastName = "Erkinov", DOB = new DateTime(1996, 4, 4), RegistrationDate = DateTime.Now };
            sl.Users.Add(usr8);
            User usr9 = new Employee() { FirstName = "Umar", LastName = "Ochilov", DOB = new DateTime(1976, 5, 5), RegistrationDate = DateTime.Now };
            User usr10 = new Employee() { FirstName = "Bekzod", LastName = "Omonov", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr11 = new Employee() { FirstName = "Saidkamol", LastName = "Saydullaev", DOB = new DateTime(1976, 5, 5), RegistrationDate = DateTime.Now };
            User usr12 = new Employee() { FirstName = "Mohira", LastName = "Bositkhonova", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr13 = new Employee() { FirstName = "Bakhodir", LastName = "Nurkhonov", DOB = new DateTime(1976, 5, 5), RegistrationDate = DateTime.Now };
            User usr14 = new Employee() { FirstName = "Hasan", LastName = "Ozodov", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr15 = new Employee() { FirstName = "Husan", LastName = "Ozodov", DOB = new DateTime(1976, 5, 5), RegistrationDate = DateTime.Now };
            User usr16 = new Employee() { FirstName = "Jahongir", LastName = "Qahramonov", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr17 = new Vendor() { FirstName = "Elbek", LastName = "Jalilov", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr18 = new Vendor() { FirstName = "Fazliddin", LastName = "Mirzaev", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr19 = new Vendor() { FirstName = "Behruz", LastName = "Elbekov", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };
            User usr20 = new Vendor() { FirstName = "Rustam", LastName = "Jalolov", DOB = new DateTime(1976, 6, 6), RegistrationDate = DateTime.Now };

            sl.Users.Add(usr9);
            sl.Users.Add(usr10);
            sl.Users.Add(usr11);
            sl.Users.Add(usr12);
            sl.Users.Add(usr13);
            sl.Users.Add(usr14);
            sl.Users.Add(usr15);
            sl.Users.Add(usr16);
            sl.Users.Add(usr17);
            sl.Users.Add(usr18);
            sl.Users.Add(usr19);
            sl.Users.Add(usr20);


            //creating flowers
            Flower flw = new Flower() { Description = "Rose",AvailableQuantity=1200, Color = "Red", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw1 = new Flower() { Description = "Lily", Color = "White",AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw2= new Flower() { Description = "Violet", Color = "Violet", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw4 = new Flower() { Description = "Amaryllis", AvailableQuantity = 1200, Color = "white", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw5 = new Flower() { Description = "Anemone", Color = "Pink", AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw6 = new Flower() { Description = "Aster", Color = "Yellow", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw7 = new Flower() { Description = "Azalea", AvailableQuantity = 1200, Color = "Pink", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw8 = new Flower() { Description = "Begonia", Color = "White", AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw9 = new Flower() { Description = "Calla Lily", Color = "White", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw10 = new Flower() { Description = "Campanula", AvailableQuantity = 1200, Color = "Red", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw11 = new Flower() { Description = "Carnation", Color = "White", AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw12 = new Flower() { Description = "Crocus", Color = "Violet", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw13 = new Flower() { Description = "Cyclamen", AvailableQuantity = 1200, Color = "pink", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw14 = new Flower() { Description = "Orchid", Color = "White", AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw15 = new Flower() { Description = "Daffodil", Color = "Yellow", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw16 = new Flower() { Description = "Dahlia", AvailableQuantity = 1200, Color = "Red", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw17 = new Flower() { Description = "Daisy", Color = "Yellow", AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw18 = new Flower() { Description = "Freesia", Color = "Violet", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw19 = new Flower() { Description = "Gardenia", AvailableQuantity = 1200, Color = "Red", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw20 = new Flower() { Description = "Geranium", Color = "White", AvailableQuantity = 1200, DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };
            Flower flw21 = new Flower() { Description = "Hether", Color = "Violet", DeliveredDate = new DateTime(2018, 10, 26), Price = 10000 };

            //adding flowers to the list of flowers
            sl.Flowers.Add(flw);
            sl.Flowers.Add(flw1);
            sl.Flowers.Add(flw2);
            sl.Flowers.Add(flw4);
            sl.Flowers.Add(flw5);
            sl.Flowers.Add(flw6);
            sl.Flowers.Add(flw7);
            sl.Flowers.Add(flw8);
            sl.Flowers.Add(flw9);
            sl.Flowers.Add(flw10);
            sl.Flowers.Add(flw11);
            sl.Flowers.Add(flw12);
            sl.Flowers.Add(flw13);
            sl.Flowers.Add(flw14);
            sl.Flowers.Add(flw15);
            sl.Flowers.Add(flw16);
            sl.Flowers.Add(flw17);
            sl.Flowers.Add(flw18);
            sl.Flowers.Add(flw19);
            sl.Flowers.Add(flw20);
            sl.Flowers.Add(flw21);

            //Creating instances of BouquetPartTemp class
            BouquetPartTemp bq = new BouquetPartTemp() { UsedFlowerTemp = flw, quantityOfUserFlower = 10 };
            BouquetPartTemp bq1 = new BouquetPartTemp() { UsedFlowerTemp = flw2, quantityOfUserFlower = 10 };
            BouquetPartTemp bq2= new BouquetPartTemp() { UsedFlowerTemp = flw1, quantityOfUserFlower = 10 };
            BouquetPartTemp bq3 = new BouquetPartTemp() { UsedFlowerTemp = flw5, quantityOfUserFlower = 10 };
            BouquetPartTemp bq4 = new BouquetPartTemp() { UsedFlowerTemp = flw4, quantityOfUserFlower = 10 };
            BouquetPartTemp bq5 = new BouquetPartTemp() { UsedFlowerTemp = flw6, quantityOfUserFlower = 10 };
            BouquetPartTemp bq6 = new BouquetPartTemp() { UsedFlowerTemp = flw7, quantityOfUserFlower = 10 };
            BouquetPartTemp bq7 = new BouquetPartTemp() { UsedFlowerTemp = flw8, quantityOfUserFlower = 10 };
            BouquetPartTemp bq8 = new BouquetPartTemp() { UsedFlowerTemp = flw9, quantityOfUserFlower = 10 };
            BouquetPartTemp bq9 = new BouquetPartTemp() { UsedFlowerTemp = flw10, quantityOfUserFlower = 10 };
            BouquetPartTemp bq10 = new BouquetPartTemp() { UsedFlowerTemp = flw11, quantityOfUserFlower = 10 };
            BouquetPartTemp bq11 = new BouquetPartTemp() { UsedFlowerTemp = flw12, quantityOfUserFlower = 10 };
           
            //creating lists of BouquetPartTemp
            List<BouquetPartTemp> flowerBouqetlist = new List<BouquetPartTemp>();
            List<BouquetPartTemp> flowerBouqetlist1 = new List<BouquetPartTemp>();
            List<BouquetPartTemp> flowerBouqetlist2 = new List<BouquetPartTemp>();
            List<BouquetPartTemp> flowerBouqetlist3 = new List<BouquetPartTemp>();

            //populating lists of BouquetPartTemp
            flowerBouqetlist.Add(bq);
            flowerBouqetlist.Add(bq1);
            flowerBouqetlist.Add(bq2);
            flowerBouqetlist.Add(bq3);

            flowerBouqetlist1.Add(bq4);
            flowerBouqetlist1.Add(bq5);


            flowerBouqetlist2.Add(bq6);
            flowerBouqetlist2.Add(bq7);
            flowerBouqetlist2.Add(bq8);

            flowerBouqetlist3.Add(bq9);
            flowerBouqetlist3.Add(bq10);
            flowerBouqetlist3.Add(bq11);
            flowerBouqetlist3.Add(bq1);

            //creating instances of Bouquet and populating it with lists of BouquetPartTemp
            Bouquet nbq = new Bouquet() { Id = 1, UsedFlowersList= flowerBouqetlist };
            Bouquet nbq1 = new Bouquet() { Id = 2, UsedFlowersList = flowerBouqetlist1 };
            Bouquet nbq2 = new Bouquet() { Id = 3, UsedFlowersList= flowerBouqetlist3 };
            Bouquet nbq3 = new Bouquet() { Id = 4, UsedFlowersList= flowerBouqetlist2 };

            //populating lists of Bouquet
            sl.Bouquets.Add(nbq);
            sl.Bouquets.Add(nbq1);
            sl.Bouquets.Add(nbq2);
            sl.Bouquets.Add(nbq3);

            //creating instances of Order
            Sale ord = new Sale() { Bouquet = nbq, Customer = usr1, SoldDate = DateTime.Now };
            Sale ord1 = new Sale() { Bouquet = nbq1, Customer = usr2, SoldDate = DateTime.Now };
            Sale ord2 = new Sale() { Bouquet = nbq2, Customer = usr3, SoldDate = DateTime.Now };
            Sale ord3 = new Sale() { Bouquet = nbq3, Customer = usr4, SoldDate = DateTime.Now};

            //populating Orders list with instances
            sl.Orders.Add(ord);
            sl.Orders.Add(ord2);
            sl.Orders.Add(ord3);
            sl.Orders.Add(ord1);

            Deliver d = new Deliver() { DeliveredFlower = flw, quantityDelivered = 10, Vendor = usr17, DeliveredDate = DateTime.Now, RecievedEmployee = usr10 };
            sl.Delivers.Add(d);

        }

    }
}
