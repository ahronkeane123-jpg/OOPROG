using PropertiesAndEncapsulation.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the Shoe class
            Shoe shoe1 = new Shoe();

            //Set properties using the setter methods 
            shoe1.Brand = "Nike";
            shoe1.Color = "Red";

            //DisplayInfo method to print shoe1's details 
            shoe1.DisplayInfo();
            Console.ReadKey();
        }
    }
}
