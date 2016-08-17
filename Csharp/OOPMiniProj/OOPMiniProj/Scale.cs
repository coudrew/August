using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class Scale
    {
        public string Root { get; set; }
        public bool Major;
        public string[] Steps = new string[7];
        private string[] Notes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };

        string[] GenerateScale(string root, bool major)
        {
            //get the index of the scales root note from Notes
            int rootIndex = Array.IndexOf(Notes, root);
            //initialize an array to hold the notes of this scale
            string[] steps = new string[7];
            //assign values to steps using curated iteration (curateration?) through Notes, adjusting index to wrap around and pull values from earlier in Notes if necessary
            for (int i = 0; i < steps.Length; i++)
            {
                if (rootIndex > Notes.Length - 1) 
                {
                    rootIndex -= Notes.Length;
                }
                steps[i] = Notes[rootIndex];
                //rootIndex must be incremented according to sequence of major/minor scale (3 tone, semitone, 2 tone semitone / tone, semitone, 3 tone, semitone, tone)
                if (major == true)
                {
                    rootIndex += i == 2 ? 1 : 2;
                } else if (major == false)
                {
                    rootIndex += i == 1 || i == 4 ? 1 : 2;
                }
            }
            return steps;
        }
        public void ShowScale()
        {
            Console.Clear();
            Console.WriteLine("***** Scale {0} {1} *****", this.Root, this.Major == false ? "Minor" : "Major");
            //Console.WriteLine(this.Root);
            //Console.WriteLine(this.Major);
            for (int i = 0; i < this.Steps.Length; i++)
            {
                Console.WriteLine(this.Steps[i]);
            }
        }
        //Constructors
        //default C major scale
        public Scale()
        {
            this.Root = "C";
            this.Major = true;
            this.Steps = GenerateScale(this.Root, this.Major);
        }
        //scale with selectable tonic and quality
        public Scale(string root, bool major)
        {
            this.Root = root;
            this.Major = major;
            this.Steps = GenerateScale(this.Root, this.Major);
        }
    }
}
