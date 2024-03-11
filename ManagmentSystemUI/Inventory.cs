using Domenic_Arias_C968.model;
using ManagmentSystemUI;
using System;
using System.ComponentModel;

namespace Domenic_Arias_C968.inventoryManagmentSystem
{
    public class Inventory
    {
        public static BindingList<Products> Products = new BindingList<Products>()
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
        public static BindingList<Parts> parts = new BindingList<Parts>();


        public static int GenerateID()
        {
            Random random = new Random();
            int newID = random.Next(1000, 9999); // Generates a random number between 1000 and 9999
            return newID;

        }

        public static void addPart(Parts part)
        {
            parts.Add(part);

        }




    }
}



