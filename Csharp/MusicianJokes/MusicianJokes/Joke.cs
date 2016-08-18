using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicianJokes
{
    class Joke
    {
        public string Setup { get; set; }
        public string PunchLine { get; set; }

        public Joke(string setup, string punchLine)
        {
            this.Setup = setup;
            this.PunchLine = punchLine;
        }
    }
}
