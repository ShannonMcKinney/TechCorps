using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void CheckForRain()
        {
            Console.Write("is it raining? (yes or no)");
            string answer = Console.ReadLine();

            if (answer == "yes")

                Console.Write("then take an umbrella");

            else
            {
                Console.Write("is it sunny? ");
                answer = Console.ReadLine();
                if (answer == "yes")
                    Console.Write("then wear sunscreen");
                if (answer == "no")
                    Console.Write("then enjoy your day");
            }
        }
        static void Main(string[] args)
        {
            CheckForRain();
        }
    }
}

//            //Prompt user for greeting
//            Console.Write("Please enter a greeting: ");
//            string greeting = Console.ReadLine();
//            Console.Write("What is your name: ");
//            string user = Console.ReadLine();

//            Console.WriteLine(greeting + " " + user);

//           /* int x = 20;
//            Console.WriteLine(2 * x + 6);
//            */ 

//        }
//    }
//}

//            system.console.writeline("please enter your age in years");
//            double age = convert.todouble(system.console.readline());
//            age = age * 365.25;
//            system.console.writeline("you are " + age + " days old");
//        }
//    }
//}

//        int exampleInt = Convert.ToInt32(Console.ReadLine());
//int piInt = 222 / 7;
//            float piFloat = 22f / 7f;
//            double piDouble = 22d / 7d;
//            decimal piDecimal = 22m / 7m;

//            Console.WriteLine("Float:" + piFloat);
//            Console.WriteLine("Double:" + piDouble);
//            Console.WriteLine("Decimal:" + piDecimal);
//        }
//    }
//}

//Console.WriteLine("What state is Cedar Point located in?");
//While(Console.ReadLine("Ohio"));

namespace MemeÉMeme
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hi, and welcome to the world of MemeÉMeme! Here, creatures called Memes roam free. People called trainers capture memes and battle them. If you win the league you can become a MemeMaster! So how 'bout it?");
            Console.Write("So are you a boy or a girl?");
            string answer = Console.ReadLine();

            if (answer == "boy")
            {
                Console.Write("and what's your name?");
            }
            else if (answer == "girl")
            {
                Console.Write("and what's your name?");
            }
            else 


