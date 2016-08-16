using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            try
            {
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
               // throw new System.ArgumentOutOfRangeException("index out of range", e);
            }
            finally
            {
                Console.WriteLine("reached finally block");
            }
        }
    }
}
