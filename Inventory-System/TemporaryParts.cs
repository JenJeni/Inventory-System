using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeniMobley.Model
{
    public static class TemporaryParts
    {
        public static BindingList<Part> TempPartsList = new BindingList<Part>();

        //Checks whether an element is selected and  which element in upper and lower grid is selected.
        public static int CurrentIndexAllParts { get; set; }
        public static int CurrentIndexAssociatedParts { get; set; }
    }
}
