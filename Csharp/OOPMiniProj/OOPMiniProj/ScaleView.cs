using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class ScaleView : View
    {
        //new public static string titleBar;
        //new public static bool open;

        public ScaleView(string title, bool status) : base(title, status)
        {
            this.TitleBar = title;
            this.Open = true;
        }
        public override void ShowView()
        {
            base.ShowView();
            //declare scale where it's accesible to all functions of main
            
            ClearTitle();
            //gather scale initialization data and instantiate scale
            Console.WriteLine("Enter a tonic to begin the scale (press enter to default to C Maj): ");
            string tonic = Console.ReadLine().ToUpper();
            if (tonic.Length < 1)
            {
                Program.scale = new Scale();
            }
            else
            {
                Console.WriteLine("Enter 'M' for major, or 'm' for minor: ");
                string qualifier = Console.ReadLine();
                bool quality = qualifier == "M" ? true : false;
                Program.scale = new Scale(tonic, quality);
            }
            //with scale now set up, enter main program
            Program.mainView.currentScale = "";
            Console.WriteLine("Ok, we have our scale, let's make some chords!");
        }
    }
}
