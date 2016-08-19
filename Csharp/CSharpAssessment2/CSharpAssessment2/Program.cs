using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    class Program
    {
        List<int> intList = new List<int>();
        public static bool running = true;
        static void Main(string[] args)
        {
            while (running == true)
            {
                Console.WriteLine("Would you like to add an integer to the list? y/n");
                string action = Console.ReadLine();
            }
        }
    }
}
