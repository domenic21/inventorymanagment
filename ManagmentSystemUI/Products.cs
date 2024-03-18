using System.ComponentModel;

namespace ManagmentSystemUI
{
    public class Products
    {
        public Products(int productID, string name, int inventory, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Min = min;
            Max = max;
        }
        public static BindingList<Products> AssociatedParts = new BindingList<Products>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }


}


