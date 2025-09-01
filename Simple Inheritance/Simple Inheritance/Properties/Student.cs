using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance.Properties
{
    internal class Student
    {
        public string Name { get; set; }
        public string Program { get; set; }
        public void BasicInfo ()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Program:" + Program);

        }
    }
    class RegularStudent : Student
    {
        public string Section { get; set; }
        public void SectionEnrolled()
        {
            Console.WriteLine("Section:" + Section);
        }
    }
    class IrregularStudent : Student 
    {
        public string EnrolledSemUnits { get; set; }
        public void EnrolledSemunits() 
        {
            Console.WriteLine("Units enrolled:" + EnrolledSemUnits);
        }
    }
 }

