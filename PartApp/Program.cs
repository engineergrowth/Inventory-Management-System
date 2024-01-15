using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and initialize Inventory with initial data
            var initialProducts = new List<Product>
            {
                new Product(1, "Red Bicycle", 114.99m, 15, 1, 25),
                new Product(2, "Yellow Bicycle", 96.99m, 19, 1, 20),
                new Product(3, "Blue Bicycle", 127.99m, 5, 1, 25)
            };

            var initialParts = new List<Part>
            {
                new Inhouse(1, "Wheel", 12.11m, 15, 5, 25, 42),
                new Inhouse(2, "Pedal", 8.22m, 11, 5, 25, 72),
                new Outsourced(3, "Chain", 8.33m, 12, 5, 25, "Chain Depot"),
                new Inhouse(4, "Seat", 4.55m, 8, 2, 15, 15)
            };

            var inventory = new Inventory(initialProducts.AsEnumerable(), initialParts.AsEnumerable());

            Application.Run(new MainForm(inventory)); // Pass inventory to main form
        }
    }
}