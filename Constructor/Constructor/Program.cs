using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a prompt message to the console
            Console.WriteLine("     Tell someone about yourself.     ");
            Console.WriteLine();

            // Create an instance of RegularStudent with name, course, and section
            RegularStudent regularStudent1 = new RegularStudent("Edryl Dogomeo", "BSIT", "IT301");

            // Call methods to display basic info and the section enrolled
            regularStudent1.BasicInfo();
            regularStudent1.SectionEnreolled();

            Console.WriteLine();
            Console.WriteLine();

            // Create an instance of IrregularStudent with name, course, and number of enrolled units
            IrregularStudent irregularStudent2 = new IrregularStudent("Keane Ahron Hiligan", "BSIT", 20);

            // Call methods to display basic info and enrolled semester units
            irregularStudent2.BasicInfo();
            irregularStudent2.EnrolledSemUnits();

            Console.ReadKey();

        }
    }
}
