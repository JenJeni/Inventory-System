using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeniMobley
{
    public class Product 
    {
        public static int prodCount = 1;

        public Product() { }

        //Six-parameter constuctor
        public Product(string prodName, int prodInStock, decimal prodPrice, int prodMin, int prodMax)
        {
            ProductID = prodCount++;

            Name = prodName;

            Stock = prodInStock;

            Price = prodPrice;

            Min = prodMin;

            Max = prodMax;
        }

        //Product class properties.
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }        
       
        public static int CurrentAssocPartIndex { get; set; }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();        
        
        public void AddAssociatedPart(Part ap)
        {
            AssociatedParts.Add(ap);
        }

        public bool RemoveAssociatedPart(Part part)
        {
           AssociatedParts.Remove(part);

           return true;
        }

        public Part LookupAssociatedPart(int currentIndex)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID.Equals(currentIndex))
                {                    
                    return AssociatedParts[i];
                }
            }
            return null;
        }
    }
}
