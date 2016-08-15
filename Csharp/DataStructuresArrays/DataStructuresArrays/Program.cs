using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = new decimal[5];
            decimal total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number for index: " + i);
                numbers[i] = Convert.ToDecimal(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("The average is: " + total/numbers.Length);
             
        }
    }
}
