using Applying_Encapsulation_with_User.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applying_Encapsulation_with_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                          Welcome to the brand new shoe            ");
            Console.WriteLine();
            //Ask the user to input
            Console.WriteLine("Enter your brand shoe: ");
            string brand = Console.ReadLine();


            Console.WriteLine("Enter your favorite color: ");
            string color = Console.ReadLine();
            Console.Clear();
            //Initialized a method
            Shoe shoe1 = new Shoe();
            shoe1.brand = brand;
            shoe1.color = color;

            //Call the method
            shoe1.Displayinfo();
            Console.ReadKey();

        }
    }
}
