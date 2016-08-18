using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicianJokes
{
    public partial class Form1 : Form
    {
        Joke[] Jokes = new Joke[10];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            Jokes[0] = new Joke("What's the difference between a drummer and a drum machine?", "You only have to punch it into the machine once.");
            Jokes[1] = new Joke("What do you call a drummer without a girlfriend?", "Homeless.");
            Jokes[2] = new Joke("What's the difference between a lead guitarist and god?", "God doesn't think he's a lead guitarist.");
            Jokes[3] = new Joke("What's the difference between a guitarist and a large pizza?", "A large pizza can feed a family of four.");
            Jokes[4] = new Joke("What do you call a beautiful woman on a keyboard player's arm?", "A tattoo");
            Jokes[5] = new Joke("What did the bassist get on his IQ test?", "Drool.");
            Jokes[6] = new Joke("What do you call a guitarist who only knows two chords?", "Music critic.");
            Jokes[7] = new Joke("What's the last thing the bassist said before he was kicked out?", "Hey guys, I wrote some songs.");
            Jokes[8] = new Joke("How do you know there's a drummer at your door?", "The knocking keeps speeding up.");
            Jokes[9] = new Joke("How many drummers does it take to screw in a light bulb?", "None. There's machines for that now.");
            setupLabel.Text = Jokes[counter].Setup;
            punchLineLabel.Text = "";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (counter + 1 < Jokes.Length)
            {
                counter++;
            } else
            {
                counter = 0;
            }
            setupLabel.Text = Jokes[counter].Setup;
            punchLineLabel.Text = "";
        }

        private void buttonPunchLine_Click(object sender, EventArgs e)
        {
            punchLineLabel.Text = Jokes[counter].PunchLine;
        }
    }
}
