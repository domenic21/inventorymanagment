using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domenic_Arias_C968.model
{
    public  class Parts(int partID, string name, double price, int inStock, int min, int max, int machineID, string companyName, string partType)
    {
        public int PartID { get; set; } = partID;
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;
        public int InStock { get; set; } = inStock;
        public int Min { get; set; } = min;
        public int Max { get; set; } = max;
        public int MachineID { get; set; } = machineID;
        public string CompanyName { get; set; } = companyName;
        public string PartType { get; set; } = partType;
    }

}
