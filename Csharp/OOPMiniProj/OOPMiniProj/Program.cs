using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale testScale = new Scale("C", true);
            Console.WriteLine(testScale.Root);
            Console.WriteLine(testScale.Major);
            for (int i = 0; i < testScale.Steps.Length; i++)
            {
                Console.WriteLine(testScale.Steps[i]);
            }
            Interval testInterval = new Interval(testScale, 0, 2);
            Console.WriteLine("*********Interval**********");
            Console.WriteLine("Base: " + testInterval.BaseNote);
            Console.WriteLine("Interval: " + testInterval.IntervalNote);
            Triad testTriad = new Triad(testScale, 4);
            testTriad.Play();
            TriadFirstInversion testInversion = new TriadFirstInversion(testScale, 4);
            testInversion.Play();

        }
    }
}
