using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp_Consoler
{
    class Program
    {
        static void Main(string[] args)
        {
            double twater;
            double tair;
            int prain;
            int time;

            Console.WriteLine("Please enter water temp. ");
            twater = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter air temp. ");
            tair = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter time");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter chance of rain ");
            prain = Convert.ToInt32(Console.ReadLine());

            if ((time >= 12) && (time <= 16) && twater >= 70 && tair > 80 && prain < 30)
            {
                Console.WriteLine("Take the kids swimming");
            }
            else if (tair > 60 && prain < 50 && time >= 10 && time <= 18)
            {
                Console.WriteLine("Go play soccer");
            }
            else if (time >= 18 || prain <= 60)
            {
                Console.WriteLine("play a board game");
            }
            else if (time > 20)
            {
                Console.WriteLine("watch a movie");
            }
        }
    }
}
