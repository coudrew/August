using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class TriadView : View
    {
        public TriadView(string title, bool status) : base(title, status)
        {
            this.TitleBar = title;
            this.Open = status;
        }

        public override void ShowView()
        {
            while (this.Open == true)
            {
                base.ShowView();
                ClearTitle();
                //get step of initial scale to build triad on
                Console.WriteLine("Enter the step of our scale to build this triad on:");
                int step = Convert.ToInt16(Console.ReadLine()) - 1;
                //ensure the selected step is within bounds, and normalize if necessary
                if (step < 0)
                {
                    step = 0;
                }
                if (step > 7)
                {
                    step = 7;
                }
                //instantiate the triad
                Triad triad = new Triad(Program.scale, step);
                //determine if this triad should be inverted
                Console.WriteLine("Is this triad inverted? Enter for no\n1 First inversion\n2 Second inversion");
                int inversion = Convert.ToInt16(Console.ReadLine());
                //apply same bounds-check and normalizing as with step above
                if (inversion > 2)
                {
                    inversion = 2;
                }
                if (inversion < 0)
                {
                    inversion = 0;
                }
                //if any inversion is selected, call Invert on the triad
                if (inversion != 0)
                {
                    triad.Invert(inversion);
                }
                //display the notes of this triad
                triad.Play();
                //propmpt the user to add this triad to the progression
                Console.WriteLine("Add this to our progression? y/n");
                string addToProg = Console.ReadLine().ToLower();
                if (addToProg == "y")
                {
                    Program.progression.AddToProgression(triad);
                }
                this.Open = false;
            }
        }
    }
}
