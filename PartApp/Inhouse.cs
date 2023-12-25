namespace PartApp
{
    public class Inhouse : Part
    {
        public int MachineId { get; set; } 

        public Inhouse(int partId, string name, decimal price, int inStock, int min, int max, int machineId)
            : base(partId, name, price, inStock, min, max)
        {
            MachineId = machineId;
        }
    }
}