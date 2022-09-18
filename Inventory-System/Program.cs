
using System;
using System.Windows.Forms;



namespace JeniMobley
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {     
            //Products.
            Inventory.Products.Add(new Product("Serene Blue", 9, 103.99M, 5, 25));
            Inventory.Products.Add(new Product("Vivre Vermilion", 8, 108.58M, 5, 25));
            Inventory.Products.Add(new Product("Ochre Whispers", 9, 111.69M, 5, 25));
            Inventory.Products.Add(new Product("Rosy Ballerina", 12, 129.99M, 10, 30));
            Inventory.Products.Add(new Product("Emerald Button", 11, 105.36M, 10, 30));

            //AllParts.
            Inventory.AllParts.Add(new Inhouse("Titanium Dioxide", 16, 49.99M, 5, 25, 12));
            Inventory.AllParts.Add(new Outsourced("Crushed Marble", 11, 30.99M, 5, 20, "Raikon Landscaping"));
            Inventory.AllParts.Add(new Inhouse("Red Pigment", 12, 54.15M, 5, 15, 45));
            Inventory.AllParts.Add(new Inhouse("Blue Pigment", 13, 26.99M, 5, 20, 36));
            Inventory.AllParts.Add(new Inhouse("Yellow Pigment", 10, 62.16M, 5, 15, 8));
            Inventory.AllParts.Add(new Outsourced("Emulsifier Agent", 6, 104.99M, 2, 10, "Karm Factory"));
            Inventory.AllParts.Add(new Outsourced("Defoamer Agent", 6, 78.99M, 2, 10, "Karm Factory"));
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
