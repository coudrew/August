using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void DisplayMedia(string[] mediaData)
        {
            
        }
        private void bookButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bookButton.Checked)
                {
                Program.fullCatalogue.currentType = 0;
                }
        }

        private void periodicalButton_CheckedChanged(object sender, EventArgs e)
        {
            if (periodicalButton.Checked)
                {
                Program.fullCatalogue.currentType = 1;
                }
        }

        private void audioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (audioButton.Checked)
            {
                Program.fullCatalogue.currentType = 2;
            }
        }

        private void videoButton_CheckedChanged(object sender, EventArgs e)
        {
            if (videoButton.Checked)
            {
                Program.fullCatalogue.currentType = 3;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Media media = Program.fullCatalogue.SearchCatalogue(titleSearchInput.Text);
            string[] mediaData = media.DisplayMediaDetails();
            titleResult.Text = mediaData[0];
            priceResult.Text = mediaData[1];
            if (mediaData.Length > 2)
            {
                authorResult.Text = mediaData[2];
                isbnResult.Text = mediaData[3];
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.opType = 0;
            form2.SetupFields();
            form2.Show();
        }
    }
}
