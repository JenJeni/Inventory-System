using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeniMobley
{
    public class Outsourced : Part
    {
        public Outsourced() { }

        public Outsourced(string partName, int partInStock, decimal partPrice, int partMin, int partMax, string companyName)
        : base(partName, partInStock, partPrice, partMin, partMax)
        {            
            this.Name = partName;

            this.Inventory = partInStock;

            this.Price = partPrice;

            this.Min = partMin;

            this.Max = partMax;

            CompanyName = companyName;
        }

        public string CompanyName { get; set; }

        public override string ToString() => $"{base.ToString()} {CompanyName}";
    }
}
