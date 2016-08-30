using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnterName_Click(object sender, EventArgs e)
    {
        outEnterName.Text = "Hello, " + txtEnterName.Text;
    }

    protected void btnCheckBox_Click(object sender, EventArgs e)
    {
        String check = cbCheckBox.Checked == true ? "checked" : "unchecked";
        outCheckBox.Text = "Checking CheckBox 'checkedCheckBox' is " + check + ", thanks for checking.";
    }

    protected void btnRadio_Click(object sender, EventArgs e)
    {
        outRadio.Text = RadioButtonList1.SelectedValue;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }

    protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
    {
        lblImgMap.Text = e.PostBackValue;
    }

    protected void btnMLTxtBox_Click(object sender, EventArgs e)
    {
        int wordCount = TextBox1.Text.Split(' ').Count();
        outMLTxtBox.Text = String.Format("You typed {0} words, all poorly chosen", wordCount);
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        outCalendar.Text = Calendar1.SelectedDate.ToString();
    }

    protected void btnDropDown_Click(object sender, EventArgs e)
    {
        outDropDown.Text = String.Format("Your favourite language is {0}?",DropDownList1.SelectedValue);
    }

    protected void btnCheckList_Click(object sender, EventArgs e)
    {
        String chosen = "You chose ";
        List<ListItem> items = new List<ListItem>();
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                items.Add(CheckBoxList1.Items[i]);
            }
        }
        for (int i = 0; i < items.Count; i++)
        {
            {
                String concatMe;
                if (items.Count == 1)
                {
                    concatMe = String.Format("{0}.", items[i]);
                }
                else if (items.Count > 1 && i == items.Count - 1)
                {
                    concatMe = String.Format(" and {0}.", items[i]);
                }
                else
                {
                    concatMe = String.Format("{0}, ", items[i]);
                }
                chosen += concatMe;
            }
        }
        outCheckList.Text = chosen;
    }
}