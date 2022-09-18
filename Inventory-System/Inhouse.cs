namespace JeniMobley
{
    public class Inhouse : Part
    {
        public Inhouse() { }

        //Seven-parameter constructor.
        public Inhouse(string partName, int partInStock, decimal partPrice, int partMin, int partMax, int machineID)
            : base(partName, partInStock, partPrice, partMin, partMax)
        {
            this.Name = partName;

            this.Inventory = partInStock;

            this.Price = partPrice;

            this.Min = partMin;

            this.Max = partMax;

            this.MachineID = machineID;
        }

        public int MachineID { get; set; }

        public override string ToString() => $"{base.ToString()} {MachineID}";
    }    
}