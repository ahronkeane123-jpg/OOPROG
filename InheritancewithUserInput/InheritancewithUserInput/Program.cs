using InheritancewithUserInput.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancewithUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Select your footwear type: ");
            Console.WriteLine(" 1 - LowTop Sneaker, 2 - HighTop Sneaker: ");
            int choice = Convert.ToInt32(Console.ReadLine());   

            if(choice == 1 ) 
            {
                LowTopSneaker lowTop1 = new LowTopSneaker();
                Console.WriteLine("Enter the Brand of the Shoe:");
                string brand = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Color of the Shoe:");
                string color = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Type of the Sneaker:");
                string type = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Size of the Sneaker:");
                string size = Console.ReadLine();
                Console.WriteLine();    

                lowTop1.Brand = brand;
                lowTop1.Color = color;
                lowTop1.Type = type;
                lowTop1.Size = size;

                lowTop1.SneakerInfo();
            }
            else if(choice == 2)
            {
                HighTop highTop1 = new HighTop();
                Console.WriteLine("Enter the Brand of the Shoe:");
                string brand = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Color of the Shoe:");
                string color = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Ankle Support of the High Top:");
                string ankleSupport = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Enter the Material of the High Top:");
                string material = Console.ReadLine();
                Console.WriteLine();


                highTop1.Brand = brand;
                highTop1.Color = color;
                highTop1.AnkleSupport = ankleSupport;
                highTop1.Material = material;
                highTop1.HighTopInfo();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
