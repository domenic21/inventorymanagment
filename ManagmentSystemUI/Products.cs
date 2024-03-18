using Domenic_Arias_C968.model;
using System.ComponentModel;

namespace ManagmentSystemUI
{
    public class Products
    {

        public  BindingList<Parts> AssociatedParts = new BindingList<Parts>();
        public Products(int productID, string name, int inventory, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Min = min;
            Max = max;
        }


        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


       
        public  void addAssociatedPart(Parts part)
        {
            AssociatedParts.Add(part);
        }

        public  void removeAssociatedPart(Parts part) { AssociatedParts.Remove(part); }
        public  Parts lookupAssociatedPart(int partID)
        {
            foreach (Parts part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }



    }


}


