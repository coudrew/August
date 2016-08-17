using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class ProgressionView : View
    {
        public ProgressionView(string title, bool status) : base(title, status)
        {
            this.TitleBar = title;
            this.Open = status;
        }

        public override void ShowView()
        {
            base.ShowView();
            while (this.Open == true)
            {
                ClearTitle();
                Console.WriteLine("Select an operation:\n'v' to view progression\n'e' to edit progression\n'q' to return to main menu");
                string action = Console.ReadLine().ToUpper();
                switch (action)
                {
                    case "V":
                        ClearTitle();
                        Program.progression.ShowProgression(1);
                        break;
                    case "E":
                        this.EditProgression();
                        break;
                    case "Q":
                        this.Open = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input"); ;
                        break;
                }
            }
        }
        public void EditProgression()
        {
            this.ClearTitle();
            Console.WriteLine("\n***** Edit *****");
            Program.progression.ShowProgression(0);
            Console.WriteLine("'R' to remove a triad\n'r' to re-order progression\n'q' to go back");
            string action = Console.ReadLine();
            switch (action)
            {
                case "R":
                    Console.WriteLine("Enter index number to swap from:");
                    int swapFrom = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter index number to swap to:");
                    int swapTo = Convert.ToInt16(Console.ReadLine());
                    Program.progression.ReorderProgression(swapFrom, swapTo);
                    Program.progression.ShowProgression(0);
                    break;
            }
        }
    }
}
