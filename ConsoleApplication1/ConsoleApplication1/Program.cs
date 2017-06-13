using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static string AskQuestion(string question);
        {
        Console.WriteLine(question);
        return Console.ReadLine();
        }

}

static void Main(string[] args)
{

    double Temperature;
    Temperature = Convert.ToDouble(AskQuestion("What is the temperature in Degrees F?"));

    if (Temperature > 80)
    {
        string waterWarm = AskQuestion("Is the water warm?");
    }
    if (waterWarm == "y")
    {
        Console.Write("Go swimming");
    }

    Console.Write("Go Swimming"); 
        
        else
        {
        Console.Write("GO swimming");
    }
}
