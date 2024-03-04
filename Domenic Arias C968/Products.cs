using System.ComponentModel;


namespace Domenic_Arias_C968.model
{
    public class Products
    {
        //properties, this will display in the form
        //get and set to be able to retrieve info and modify
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        //binding list should be reference in code form1
        public static BindingList<Products> products = new BindingList<Products>();


        //hardcode values as products
        static Products()
        {
            products.Add(
            new Products
                  {
             ProductId = 1,
             Name = "Suspension",
             Inventory = 10,
             Price = 1000,
             Min = 1,
             Max = 10
                  });
            products.Add(
            new Products
            {
                ProductId = 2,
                Name = "Wheel",
                Inventory = 10,
                Price = 150,
                Min = 1,
                Max = 10
            });

            products.Add(
               new Products
               {
                   ProductId = 3,
                   Name = "Steering",
                   Inventory = 10,
                   Price = 200,
                   Min = 1,
                   Max = 10
               });

            products.Add(
               new Products
               {
                   ProductId = 4,
                   Name = "Ignition",
                   Inventory = 10,
                   Price = 500,
                   Min = 1,
                   Max = 10
               });

            products.Add(
          new Products
          {
              ProductId = 4,
              Name = "Ignition",
              Inventory = 10,
              Price = 500,
              Min = 1,
              Max = 10
          });











        }

        public override string ToString()
        {
            return "[" + ProductId + "] ==>"+Name + "-" + Inventory+ Price + Min + Max;

        }








    }
}
