using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Functions
{
    
    class Program
    {
        static string createNameString(string firstName, string lastName) //method header
        {
            string fullname = firstName + " " + lastName;
            return fullname;
        }
        static void giveStudentGrade(string firstName, string lastName, int score)
        {
            string grade = "A";
            if (score > 79 && score < 90)
            {
                grade = "B";
            }
            else if (score > 69 && score < 80)
            {
                grade = "C";
            }
            Console.WriteLine(firstName + " " + lastName + ": " + grade);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(createNameString("Iona", "Ford"));
            giveStudentGrade("Tim", "Burr", 80);
        }
    }
}
