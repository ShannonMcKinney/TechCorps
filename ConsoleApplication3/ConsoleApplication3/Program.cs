using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static string createNameString(string firstName, string lastName)
        {
            string fullname = firstName + " " + lastName;
            return fullname;
        }
        static void Main(string[] args)
        {
            int score = 
            string grade = "A";
            if (score > 79 && score < 90)
            {
                grade = "B";
            }
            else if (score > 69 && score < 80)
            {
                grade = "C";
            }
            else if (score > 59 && score < 70)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
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
