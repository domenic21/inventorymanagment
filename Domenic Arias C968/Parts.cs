using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domenic_Arias_C968.model
{
    internal class Parts
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int MachineID { get; set; }
        public string CompanyName { get; set; }
        public string PartType { get; set; }

        public Parts(int partID, string name, double price, int inStock, int min, int max, int machineID, string companyName, string partType)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
            CompanyName = companyName;
            PartType = partType;
        }
    }

}
