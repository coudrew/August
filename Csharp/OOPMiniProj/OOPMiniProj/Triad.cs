using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class Triad 
    {
        public string Root { get; set; }
        public string Third { get; set; }
        public string Fifth { get; set; }
        public string Name { get; set; }

        public Triad(Scale scale, int step)
        {
            //assign notes from provided scale to their position in the triad
            //uses similar index augmentation as Scale does to pull its data from Notes
            this.Root = scale.Steps[step];
            step = step + 2 >= scale.Steps.Length ? step + 2 - scale.Steps.Length : step + 2;
            this.Third = scale.Steps[step];
            step = step + 2 >= scale.Steps.Length ? step + 2 - scale.Steps.Length : step + 2;
            this.Fifth = scale.Steps[step];
        }
        public virtual void Play()
        {
            //Display the triad, pretend it does something more interesting
            Console.WriteLine("The notes of " + this.Root + " triad are:\n");
            Console.WriteLine(this.Root + " " + this.Third + " " + this.Fifth);
            
        }
    }
}
