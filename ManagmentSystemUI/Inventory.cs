using Domenic_Arias_C968.model;
using ManagmentSystemUI;
using System.ComponentModel;

namespace Domenic_Arias_C968.inventoryManagmentSystem
{
    public static class Inventory
    {
        private static BindingList<Products> products = new BindingList<Products>()
        {

            new Products
            {
                ProductID = 1,
                Name = "Wheel",
                Inventory = 10,
                Price = 150,
                Min = 1,
                Max = 10
            },
            new Products
               {
                   ProductID = 2,
                   Name = "Steering",
                   Inventory = 10,
                   Price = 200,
                   Min = 1,
                   Max = 10
               },
            new Products
               {
                   ProductID = 3,
                   Name = "Ignition",
                   Inventory = 10,
                   Price = 500,
                   Min = 1,
                   Max = 10
               },
            new Products
          {
             ProductID = 4,
              Name = "Ignition",
              Inventory = 10,
              Price = 500,
              Min = 1,
              Max = 10
          },









    };
        public static BindingList<Parts> parts = new BindingList<Parts>()
        {
            new Parts
            {
                PartID = 1,
                Name = "Bolts",
                Price = 150,
                InStock = 10,
                Min = 1,
                Max = 10,
            
            },
            new Parts
            {
                PartID = 2,
                Name = "Nuts",
                Price = 200,
                InStock = 10,
                Min = 1,
                Max = 10,
               
            },
                new Parts
                {
                PartID = 3,
                Name = "Screws",
                Price = 500,
                InStock = 10,
                Min = 1,
                Max = 10,
             
            },
        };
        public static BindingList<Parts> Parts { get { return parts; } }

        public static BindingList<Products> Products { get => products; set => products = value; }
    }
}



