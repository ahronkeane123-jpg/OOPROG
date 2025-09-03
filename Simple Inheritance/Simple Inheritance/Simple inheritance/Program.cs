using Simple_inheritance.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_inheritance
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Create a RegularStudent object and set its properties
            RegularStudent regularStudent = new RegularStudent()
            {
                Name = "Keane Hiligan",
                Program = "BSIT",
                Section = "IT301",
            };
            regularStudent.BasicInfo();// Display regular student info
            regularStudent.SectionEnrolled();

            // Create an IrregularStudent object and set its properties
            IrregularStudent irregularStudent1 = new IrregularStudent()
            {
               Name = "Ahron Hiligan",
               Program = "BSIT",
               UnitsEnrolled = 18,
            };
            irregularStudent1.BasicInfo();// Display irregular student info
            irregularStudent1.EnrolledSemunits();
            Console.ReadKey();
        }
    }
}
