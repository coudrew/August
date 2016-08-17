using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class Progression
    {
        public List<Triad> progression = new List<Triad>();
        public bool open = true;
        public static string titleBar = "\n***** Progression *****";
        public void ShowProgression(int prompt)
        {
            int showPrompt = prompt;
            string numberHeading = "";
            string line1 = "";
            string line2 = "";
            string line3 = "";
            int triadNumber = 0;
            foreach (Triad triad in progression)
            {
                triadNumber++;
                numberHeading += triadNumber + " "; 
                line1 += triad.Root + " ";
                line2 += triad.Third + " ";
                line3 += triad.Fifth + " ";
            }
            Console.WriteLine(numberHeading);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            if (showPrompt == 1)
            {
                Console.WriteLine("Press enter to return to previous menu...");
                Console.ReadLine();
            }
        }
        public void AddToProgression(Triad triad)
        {
            this.progression.Add(triad);
        }
        public void RemoveFromProgression(int index)
        {
            Program.progression.progression.RemoveAt(index);
        }
        public void ReorderProgression(int indexFrom, int indexTo)
        {
            Triad tempFrom = Program.progression.progression[indexFrom];
            Triad tempTo = Program.progression.progression[indexTo];
            Program.progression.progression[indexFrom] = tempTo;
            Program.progression.progression[indexTo] = tempFrom;
        }
        //method to clear screen and display the title bar. keeping it DRY
        public static void ClearTitle()
        {
            Console.Clear();
            Console.WriteLine(titleBar);
        }
    }
}
