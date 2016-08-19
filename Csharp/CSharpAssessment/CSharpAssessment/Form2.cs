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
    public partial class Form2 : Form
    {
        public int opType { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public void SetupFields()
        {
            switch (Program.fullCatalogue.currentType)
            {
                case 0:
                    authorLabel.Text = "Author";
                    isbnLabel.Text = "ISBN";
                    break;
                case 1:
                    authorLabel.Text = "Publisher";
                    isbnLabel.Text = "ISSN";
                    break;
                case 2:
                    authorLabel.Text = "Artist";
                    isbnLabel.Text = "ISBN";
                    break;
                case 3:
                    authorLabel.Text = "Director/Producer";
                    isbnLabel.Text = "ISBN";
                    break;
            }
            if (this.opType == 0)
            {
                addRemoveLabel.Text = "Add Media";
                addRemoveButton.Text = "Add";
            }
            if (this.opType == 1)
            {
                addRemoveLabel.Text = "Remove Media";
                addRemoveButton.Text = "Remove";
            }

        }
        private void addRemoveButton_Click(object sender, EventArgs e)
        {
            if (opType == 0)
            {
                switch (Program.fullCatalogue.currentType)
                {
                    case 0:
                        Program.fullCatalogue.AddToCatalogue(new MediaBook(titleInput.Text, priceInput.Text, authorInput.Text, isbnInput.Text));
                        break;
                    case 1:
                        Program.fullCatalogue.AddToCatalogue(new MediaPeriodical(titleInput.Text, priceInput.Text, authorInput.Text, isbnInput.Text));
                        break;
                    case 2:
                        Program.fullCatalogue.AddToCatalogue(new MediaAudio(titleInput.Text, priceInput.Text, authorInput.Text, isbnInput.Text));
                        break;
                    case 3:
                        Program.fullCatalogue.AddToCatalogue(new MediaVideo(titleInput.Text, priceInput.Text, authorInput.Text, isbnInput.Text));
                        break;
                }
                this.Hide();
                this.Dispose();
            }
            if (opType == 1)
            {
                Program.fullCatalogue.RemoveFromCatalogue(titleInput.Text);
                this.Hide();
                this.Dispose();
            }
        }
    }
}
