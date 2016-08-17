using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class MainView : View
    {
        public string currentScale = "default Cmaj ";
        public MainView(string title, bool status) : base(title, status)
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
                Console.WriteLine("Select a task:\n's' to change the {0}scale\n't' to create a triad\n'c' to create a chord\n'p' to display our current progression and it's options\n'q' to quit", currentScale);
                string action = Console.ReadLine().ToLower();
                switch (action)
                {
                    case "s":
                        Program.scaleView.Open = true;
                        Program.scaleView.ShowView();
                        break;
                    case "t":
                        Program.triadView.Open = true;
                        Program.triadView.ShowView();
                        break;
                    case "p":
                        Program.progression.open = true;
                        Program.progressionView.ShowView();
                        break;
                    case "q":
                        //confirm whether or not quit was intentional
                        Console.WriteLine("\nFor reals? y/n");
                        string quitChoice = Console.ReadLine().ToLower();
                        //set running param to false, break main while loop and exit program
                        if (quitChoice == "y")
                        {
                            this.Open = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
