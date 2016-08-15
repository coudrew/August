using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Riddle[] riddles = new Riddle[5];
            riddles[0] = new Riddle("What do you call a drummer without a girlfriend?", "Homeless");
            riddles[1] = new Riddle("What do you call a bassist WITH a girlfriend?", "Liar");
            riddles[2] = new Riddle("What's the difference between a guitarist and a large pizza?", "A large pizza can feed a family of four");
            riddles[3] = new Riddle("How many drummers does it take to change a lightbulb?", "One to change the bulb, two to talk about how Neil Peart would've done it");
            riddles[4] = new Riddle("What's the range on a 5-string, fretless bass?", "50ft, with a good arm");
            for (int i = 0; i < riddles.Length; i++)
            {
                string answer;
                do
                {
                    riddles[i].Display();
                    answer = Console.ReadLine();
                    if (answer == riddles[i].answer)
                    {
                        Console.WriteLine("\n Correct!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n Try again! Funnier this time though...");
                    }
                } while (answer != riddles[i].answer);
            }
        }
    }
}
