using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Base class representing a general student
    internal class Student
    {
        // Fields to store student name and program
        public string name;
        public string program;


        // Constructor to initialize the student's name and program
        public Student(string aName, string aProgram)
        {
            name = aName;
            program = aProgram;
        }
        // Method to display basic information about the student
        public void BasicInfo()
        {
            Console.WriteLine("My name is: " + name + ". Taking the program. " + program + ".");

        }
 
    }
    // Derived class representing a regular student

    class RegularStudent : Student 
    {
        // Additional field to store section information
        public string section;

        public RegularStudent(string aName, string aProgram, string aSection) : base(aName, aProgram) 
        {
            section = aSection;
        }
        // Method to display the section and indicate student is regular
        public void SectionEnreolled() 
        {
            Console.WriteLine(" Current section: " + section + ". I'm Regular Student.");
        }
    }
    // Derived class representing an irregular student
    class IrregularStudent : Student 
    {
        public int unitsEnrolled;

        // Constructor to initialize name, program, and units enrolled
        public IrregularStudent(string aName, string aProgram, int theUnitsEnrolled ) : base(aName, aProgram)
        {
            unitsEnrolled = theUnitsEnrolled;
        }
        // Method to display the number of units enrolled and indicate student is irregular

        public void EnrolledSemUnits()
        {
            Console.WriteLine("Amount of the units I enrolled is: " + unitsEnrolled + ". I'm Irregular Student. ");
        }

    }
        
    
}

