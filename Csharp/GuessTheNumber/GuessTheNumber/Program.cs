using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(11);
            bool playing = true;
            while (playing == true)
            {
                Console.WriteLine("Guess a number between 0 and 10 (guess 11 to quit)");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("You win!");
                    playing = false;
                }
                else if (guess == 11)
                {
                    return;
                } else if (guess == 1337)
                {
                    Console.WriteLine(randomNumber);
                } else
                {
                    Console.WriteLine("you lose!");
                }
            }
            
        }
    }
}
