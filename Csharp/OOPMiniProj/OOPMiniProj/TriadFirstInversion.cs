/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    [System.Obsolete("deprecated, use Triad.Invert()")]
    //////////////////////////////////////////////////////////////////////////
    ///////////////////this class has been deprecated, use Triad.Invert() instead
    class TriadFirstInversion : Triad
    {
        public TriadFirstInversion(Scale scale, int step) : base( scale,  step)
        {
            //assign notes from provided scale to their position in the triad
            //uses similar index augmentation as Scale does to pull its data from Notes
            this.Root = scale.Steps[step];
            step = step + 2 >= scale.Steps.Length ? step + 2 - scale.Steps.Length : step + 2;
            this.Third = scale.Steps[step];
            step = step + 2 >= scale.Steps.Length ? step + 2 - scale.Steps.Length : step + 2;
            this.Fifth = scale.Steps[step];
        }
        public override void Play()
        {
            Console.WriteLine("The notes of " + this.Root + " triad in the first inversion are:\n");
            Console.WriteLine(this.Third + " " + this.Fifth + " " + this.Root);
        }
    }
}*/
