using Domenic_Arias_C968.model;

namespace ManagmentSystemUI
{
    public class InHouse : Parts
    {
        public InHouse(int partID, int inventory, int min, int max, decimal price, string name, int machineID)
         : base(partID, inventory, min, max, price, name)
        {
            MachineID = machineID;
        }



        public int MachineID { get; set; }

    }
}
