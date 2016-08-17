using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiniProj
{
    abstract class View
    {
        public string TitleBar { get; set; }
        public bool Open { get; set; }

        public View(string title, bool status)
        {
            this.TitleBar = title;
            this.Open = status;

        }
        public virtual void ShowView()
        {

        }
        public void ClearTitle()
        {
            Console.Clear();
            Console.WriteLine(this.TitleBar);
        }
    }
}
