using Simple_Inheritance.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularStudent regularStudent = new RegularStudent();
            {
                regularStudent.Name = "Keane Hiligan";
                regularStudent.Program = "BSIT";
                regularStudent.Section = "IT301";
            }
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();

            IrregularStudent irregularStudent1=new IrregularStudent();
            {
                irregularStudent1.Name = 
            }
        }
    }
}
