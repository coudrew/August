using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    class Program
    {
        public static Progression progression = new Progression();
        public static Scale scale = new Scale();
        public static bool running = true;
        public static string titleBar = "\n***** Chordia *****";
        public static MainView mainView = new MainView("\n***** Chordia *****", true);
        public static ProgressionView progressionView = new ProgressionView("\n***** Progression *****", true);
        public static ScaleView scaleView = new ScaleView("\n***** Scale *****", true);
        public static TriadView triadView = new TriadView("\n***** Triad *****", true);

        static void Main(string[] args)
        {   
            mainView.ShowView();
        }
        //method to clear screen and display the title bar. keeping it DRY
        public static void ClearTitle()
        {
            Console.Clear();
            Console.WriteLine(titleBar);
        }
    }
}
