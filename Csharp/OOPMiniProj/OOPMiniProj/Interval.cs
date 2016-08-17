/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    [System.Obsolete("deprecated, see Interval.cs for more info")]
    class Interval
    {   //**********************************************************************************
        //This class has been deprecated and will be replaced with a Diad subclass of Triad
        //**********************************************************************************
        public string BaseNote;
        public string IntervalNote;
        public Interval(Scale scale, int step, int value)
        {
            this.BaseNote = scale.Steps[step];
            step += value;
            if (step >= scale.Steps.Length)
            {
                Console.WriteLine(step);
                step -= scale.Steps.Length;
            }
            this.IntervalNote = scale.Steps[step];
        }
    }
}*/
