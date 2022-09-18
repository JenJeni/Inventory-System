using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeniMobley
{
    public static class Inventory
    {       
        public static int SelectedPartIndex { get; set; }
        
        public static int SelectedProductIndex { get; set; }

        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        #region Product Methods
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int prodIndex)
        {
            prodIndex--;

            return Products.Remove(Products[prodIndex]);
            
        }

        public static Product LookupProduct(int prodIndex)
        {
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j].ProductID.Equals(prodIndex))
                {                    
                    return Products[j];
                }
            }

            return null;
        }

        public static void UpdateProduct(int prodIndex, Product prod)
        {
            //prodIndex--;

            Products[prodIndex] = prod;
        }
        #endregion

        #region Part Methods
        public static void AddPart(Part allPart)
        {
            AllParts.Add(allPart);
        }

        public static bool DeletePart(int indx)
        {           
            return AllParts.Remove(AllParts[indx]);           
        }

        public static Part LookupPart(int indx)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID.Equals(indx))
                {                    
                    return AllParts[i];
                }
            }
            return null;
        }

        public static void UpdatePart(int indx, Part allParts)
        {
            AllParts[indx] = allParts;
        }
        #endregion
    }
}