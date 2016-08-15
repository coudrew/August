using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are 3 candidates for POTUSA: \n 1 - Donald Trump, \n 2 - Hillary Clinton, \n 3 - a bag of actual shit. \n Choose who would be best to lead the US right now.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("So you're painfully xenophobic?");
                    break;
                case 2: Console.WriteLine("So you're afraid people will find out you're painfully xenophobic?");
                    break;
                case 3: Console.WriteLine("Trick question, Trump and Clinton are BOTH bags of actual shit");
                    break;
                default: Console.WriteLine("I supersize with you, but you have to pick one.");
                    break;
            }
        }
    }
}
