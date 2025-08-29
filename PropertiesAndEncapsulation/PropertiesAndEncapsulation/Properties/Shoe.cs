
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndEncapsulation.Properties
{
    internal class Shoe
    {
        private string brand;
        private string color;

        //Setting properties for the fields 
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Method to display shoe information 
        public void DisplayInfo()
        {
            Console.Write("The basketball brand shoe is: " + Brand);
            Console.WriteLine();
            Console.Write("Color of the shoe: " + Color);
            Console.ReadKey();
        } 
    }
}
