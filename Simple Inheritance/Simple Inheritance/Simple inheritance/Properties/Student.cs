using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_inheritance.Properties
{
    internal class Student
    {
        public string Name { get; set; }
        public string Program { get; set; }

        public void BasicInfo()// Displays basic student info
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Program: " + Program);

        }
    }
    // Derived class for regular students
    class RegularStudent : Student
    {
        public string Section { get; set; }
        public void SectionEnrolled()
        {
            Console.WriteLine("Section: " + Section);
            Console.WriteLine();
        }
    }
    // Derived class for irregular students
    class IrregularStudent : Student
    {
        public int UnitsEnrolled { get; set; }
        public void EnrolledSemunits()
        {
            Console.WriteLine("Units enrolled: " + UnitsEnrolled);
        }
    }
}
