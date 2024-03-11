using Domenic_Arias_C968.model;

namespace ManagmentSystemUI
{
    public class Outsource : Parts
    {
        public Outsource(int partID, int inventory, int min, int max, decimal price, string name, string companyName) : base(partID, inventory, min, max, price, name)

        {
            CompanyName = companyName;

        }

        public string CompanyName { get; set; }


    }


}