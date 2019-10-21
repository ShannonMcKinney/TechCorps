using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello and welcome to the world of MemeÉMeme. My name is JEFF...");
            Console.Write("Ummmm... I mean  Professor Jeff. Here, Memes roam freely and people called Meme Trainors catch   and battle each other with their Memes.");
            Console.Write(" So what do you say? Want to start your   MemeÉMeme adventure?");
            Console.Write(" Are you a boy or a girl?  ");
            string answer = Console.ReadLine();
            if (answer == "girl")
            {
                Console.Write("And what's your name?");
                
            }
            else if (answer == "boy")
            {

            }
            else
            {
                Console.Write("What?! Tell me, are you a boy or a girl?");
            }
            string answers = Console.ReadLine();

        }
         Console.WriteLine("And what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Now its time to choose your starter");


            string memeememe = "";
            int p = 0;
            while (memeememe != "Big Smoke!" && memeememe != "Snoop Dogg" && memeememe != "Robbie Rotten")
            {
                if (p > 0)
                {
                    Console.WriteLine("No, pick one of these.");
                }
                else
                {
                    Console.WriteLine("There's Big Smoke!, the fire-type, Snoop Dogg, the grass-type, and              Robbie Rotten, the water-type.");
                }

                memeememe = Console.ReadLine();
                p++;

            }
            //put a save

            Console.Write("Congratulations! You now have your first MemeÉMeme!");
            Console.Write(" Now go on to route one and  start your adventure!");

            Character myCharacter = new Character();
            Meme myMeme = new Meme(3);
            Meme myMeme2 = new Meme(5);
            Meme myMeme3 = new Meme(12);
            Meme myMeme4 = new Meme(15);
            Meme myMeme5 = new Meme(18);
            Console.WriteLine(" Use w key to move forward and s key to move back towards  the first town.");

            int value = 0;
            int routeDistance = 0;
            string input = " ";
            while (input != "q")
            {

                input = Console.ReadLine();
                if (input == "w")
                {
                    myCharacter.walk("u", 1);
                    routeDistance++;
                }
                if (input == "a")
                {
                    myCharacter.walk("1", 1);
                }
                if (input == "s")
                {
                    myCharacter.walk("d", 1);
                    routeDistance--;
                }
                if (input == "d")
                {
                    myCharacter.walk("r", 1);
                }
                if (input == "e")
                {
                    myCharacter.attack(myMeme);
                }
               
                if (myCharacter.myLoc.y == 3) //encounters
                {
                    Console.WriteLine("A Meme attacked! Quick press e to capture it!");
                    if (Console.ReadLine() == "e")
                    {
                        Console.Write("Congratulations! You caught a Windows. ");
                        value++;
                    }

                }
                if (myCharacter.myLoc.y == 5) //encounters
                {
                    Console.WriteLine("A Meme attacked! Quick press e to capture it!");
                    if (Console.ReadLine() == "e")
                    {
                        Console.Write("Congratulations! You caught a Mcxuse me. ");
                        value++;
                    }

                }
                if (myCharacter.myLoc.y == 12) //encounters
                {
                    Console.WriteLine("A Meme attacked! Quick press e to capture it!");
                    if (Console.ReadLine() == "e")
                    {
                        Console.Write("Congratulations! You caught a Wednesday my dudes. ");
                        value++;
                    }

                }
                if (myCharacter.myLoc.y == 15) //encounters
                {
                    Console.WriteLine("A Meme attacked! Quick press e to capture it!");
                    if (Console.ReadLine() == "e")
                    {
                        Console.Write("Congratulations! You caught a This is how you eat a Big Mac. ");
                        value++;
                    }

                }
                if (myCharacter.myLoc.y == 18) //encounters
                {
                    Console.WriteLine("A Meme attacked! Quick press e to capture it!");
                    if (Console.ReadLine() == "e")
                    {
                        Console.Write("Congratulations! You caught a Did you steal my Mountain Dew? ");
                        value++;
                    }
                }
                myCharacter.describe();
                //myMeme.describe();
                //myMeme2.describe();
                //myMeme3.describe();
                //myMeme4.describe();
                //myMeme5.describe();

                if (routeDistance >= 20)
                {
                    Console.WriteLine("Congratualtions you have made it to the next town! what would you like to do?      (type c for MemeÉMeme center, type m for MemeÉMeme mart, type g to challenge the gym, type h to enter a house.)");
                }
                if (routeDistance <= -1)
                {
                    Console.WriteLine("You have traveled back to the first town. what would you like to do? (type c     for MemeÉMeme center, type m for MemeÉMeme mart, type h to enter a house.");
                }
                if (input == "h")
                {
                    Random rand = new Random();
                    int answer = rand.Next(1, 11);
                    if (answer == 7)
                    {
                        Console.WriteLine("You found a MemeÉBall! You put it in the items pocket.");
                    }
                    else
                    {
                        Console.WriteLine("Too bad. The house was empty.");
                    }
                }
                if (input == "g" && value >= 3)
                {
                    Console.WriteLine("You beat the gym and got the Totinos Pizza Badge!");
                }
                else if (input == "g" && value < 3) 
                {
                    Console.WriteLine("Too bad. You lost the battle.");
                }
                if (input == "m")
                {
                    Console.WriteLine("Welcome to the Meme Mart. What would you like to buy? x for MemeÉBall, y for    Mountain Dew and z for an Airhorn.");
                }
                if (input == "x")
                {
                    Console.WriteLine("You bought a MemeÉBall.");
                }
                if (input == "y")
                {
                    Console.WriteLine("You bought a Mountain Dew");
                }
                if (input == "z")
                {
                    Console.WriteLine("You bought an Airhorn.");
                }
                if (input == "c")
                {
                    Console.WriteLine("You healed your Memes");
                }
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2._0
{
    class Character : Inheritance
    {
        public Character()
        {
            myLoc = new Loc();
            myLoc.y = 0;
        }

        public void attack(Meme lunch)
        {
            if (this.myLoc.y == lunch.myLoc.y)
            {
                Console.WriteLine("");//meme encounter 
            }
            else
            {
                Console.WriteLine("No Meme in sight");
            }
        }

        public void describe()
        {
            Console.WriteLine("You are at " + this.myLoc.y);
            
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2._0
{
    class Inheritance
    {
        public int age;
        public string color;
        public int weight;
        public Loc myLoc;

        public void walk(string dir, int speed)
        {
            //u for up, d for down, l for left, r for right
            if (dir == "u")
            {
                this.myLoc.y += speed;
            }

            if (dir == "d")
            {
                this.myLoc.y -= speed;
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2._0
{
     public class Loc
    {
            public int y;
    }
} 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2._0
{
    class Meme : Inheritance
    {
        public Meme(int startY)
        {
            myLoc = new Loc();
            myLoc.y = startY;

        }
        public void describe()
        {
            Console.WriteLine("The Meme is at " + this.myLoc.y);
        }
    }
}
    }
}
