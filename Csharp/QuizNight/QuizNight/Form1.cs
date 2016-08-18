using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNight
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void q1a1_CheckedChanged(object sender, EventArgs e)
        {
            if (q1a1.Checked)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "\u00fc"; //tick
                q1Correct = true;
            }
        }

        private void q1a2_CheckedChanged(object sender, EventArgs e)
        {
            if (q1a2.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb"; //cross
                q1Correct = false;
            }

        }

        private void q1a3_CheckedChanged(object sender, EventArgs e)
        {
            if (q1a3.Checked)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "\u00fb"; //cross
                q1Correct = false;
            }


        }

        private void q2a1_CheckedChanged(object sender, EventArgs e)
        {
            if (q2a1.Checked)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "\u00fb";
                q2Correct = false;
            }
        }

        private void q2a2_CheckedChanged(object sender, EventArgs e)
        {
            if(q2a2.Checked)
            {
                label5.ForeColor = Color.Green;
                label5.Text = "\u00fc";
                q2Correct = true;
            }
        }

        private void q2a3_CheckedChanged(object sender, EventArgs e)
        {
            if(q2a3.Checked)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "\u00fb";
                q2Correct = false;
            }
        }

        private void q3a1_CheckedChanged(object sender, EventArgs e)
        {
            if (q3a1.Checked)
            {
                label7.ForeColor = Color.Green;
                label7.Text = "\u00fc";
                q3Correct = true;
            }
        }

        private void q3a2_CheckedChanged(object sender, EventArgs e)
        {
            if (q3a2.Checked)
            {
                label7.ForeColor = Color.Red;
                label7.Text = "\u00fb";
                q3Correct = false;
            }
        }

        private void q3a3_CheckedChanged(object sender, EventArgs e)
        {
            if (q3a3.Checked)
            {
                label7.ForeColor = Color.Red;
                label7.Text = "\u00fb";
                q3Correct = false;
            }
        }
    }
}
