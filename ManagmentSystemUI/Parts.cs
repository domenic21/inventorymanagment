namespace Domenic_Arias_C968.model
{
    public abstract class Parts
    {

        public Parts(int partID, int inventory, int min, int max, decimal price, string name)
        {
            PartID = partID;
            Min = min;
            Max = max;
            Price = price;
            Name = name;
            InStock = inventory;


        }

        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }


}
