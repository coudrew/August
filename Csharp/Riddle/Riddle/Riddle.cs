using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddle
{
    class Riddle
    {
        public string riddle;
        public string answer;
        public Riddle(string riddle, string answer)
        {
            this.riddle = riddle;
            this.answer = answer;
        }

        public void Display()
        {
            Console.WriteLine(this.riddle + "\n");
        }
    }
}
