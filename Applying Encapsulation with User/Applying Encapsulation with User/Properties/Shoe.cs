using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applying_Encapsulation_with_User.Properties
{
    internal class Shoe
    {
        //Setting properties for the fields 
        public string brand { get; set; }
        public string color { get; set; }

        //Method to display shoe information 
        public void Displayinfo()
        {
            Console.WriteLine();
            Console.WriteLine("             Brand of the shoe:     ");
            Console.WriteLine();
            Console.WriteLine("                     The Color:     ");
            Console.ReadKey();

        }
    }
}
