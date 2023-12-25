using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Add this line

namespace PartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new MainForm()); 
        }
    }
}