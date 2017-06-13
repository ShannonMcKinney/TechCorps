using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentInClass = new string[5];
            studentInClass[0] = "Colin";
            studentInClass[1] = "Anthony";
            studentInClass[2] = "Jeffery";
            studentInClass[3] = "Shannon";
            studentInClass[4] = "Ani";

            //int i = 0;
            //while (i < studentInClass.Length)
            //{
            //    Console.WriteLine(studentInClass[i]);
            //    i++;
            //}
            for (int i = 0; i < studentInClass.Length; i++)
            {
                Console.WriteLine(studentInClass[i]);
            }
        }
    }
}
