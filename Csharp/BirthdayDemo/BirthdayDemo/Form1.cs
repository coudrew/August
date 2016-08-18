using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayDemo
{
    public partial class Form1 : Form
    {
        string name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get name from text box
            name = textBoxName.Text;

            //work out how old the person is in days
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker.Value;

            //work age in years
            int years = ((int)ageDays.TotalDays) / 365;

            //get date from picker to use in message
            int day = dateTimePicker.Value.Day;
            //get the month as a word
            string month = dateTimePicker.Value.ToString("MMMM");

            //assemble message
            label3.Text = "Hello, " + name + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
