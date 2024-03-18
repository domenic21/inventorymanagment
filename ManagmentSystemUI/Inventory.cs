using Domenic_Arias_C968.model;
using ManagmentSystemUI;
using System;
using System.ComponentModel;

namespace Domenic_Arias_C968.inventoryManagmentSystem
{
    public class Inventory
    {
        public static BindingList<Products> Products = new BindingList<Products>();



        public static BindingList<Parts> AllParts = new BindingList<Parts>();


        //int partID, int inventory, int min, int max, decimal price, string name, int machineID






        // method to generate a random ID
        public static int GenerateID()
        {
            Random random = new Random();
            int newID = random.Next(1000, 9999); // Generates a random number between 1000 and 9999
            return newID;

        }

        // method for parts
        public static void addPart(Parts AllPart)
        {
            AllParts.Add(AllPart);


        }
        public static bool deletePart(Parts part)
        {
            AllParts.Remove(part);
            return true;
        }

        public static Parts lookupPart(int partID)
        {
            foreach (Parts part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public static void updatePart(int partID, Parts part)
        {


            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == part.PartID)
                {
                    if (AllParts[i] is InHouse newInHouse)
                    {
                        newInHouse.Name = part.Name;
                        newInHouse.InStock = part.InStock;
                        newInHouse.Price = part.Price;
                        newInHouse.Min = part.Min;
                        newInHouse.Max = part.Max;
                        newInHouse.MachineID = ((InHouse)part).MachineID;
                    }
                    else if (AllParts[i] is Outsource newOutsource)
                    {
                        newOutsource.Name = part.Name;
                        newOutsource.InStock = part.InStock;
                        newOutsource.Price = part.Price;
                        newOutsource.Min = part.Min;
                        newOutsource.Max = part.Max;
                        newOutsource.CompanyName = ((Outsource)part).CompanyName;
                    }
                }
            }

        }



        // method for products
        public static void addProduct(Products product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(Products product)
        {
            Products.Remove(product);
            return true;
        }
        public static Products lookupProduct(int productID)
        {
            foreach (Products product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public static void updateProduct(int productID, Products updatedproduct)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    product.AssociatedParts = updatedproduct.AssociatedParts;
                    product.Name = updatedproduct.Name;
                    product.Price = updatedproduct.Price;
                    product.Inventory = updatedproduct.Inventory;
                    product.Min = updatedproduct.Min;
                    product.Max = updatedproduct.Max;
                    return;
                }
            }
        }





    }
}



