using System;

namespace JeniMobley
{
    public abstract class Part
    {
        private static int partCount;

        #region Constructors
        public Part() { }

        public Part(string partName, int partInStock, decimal partPrice, int partMin, int partMax)
        {
            PartID = partCount++;

            Name = partName;

            Inventory = partInStock;

            Price = partPrice;

            Min = partMin;

            Max = partMax;
        }
        #endregion

        #region Properties
        public int PartID { get; set; }

        public string Name { get; set; }

        public int Inventory { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        #endregion

        public override string ToString() => $"{PartID} {Name} {Inventory} {Price} {Min} {Max}";
    }
}