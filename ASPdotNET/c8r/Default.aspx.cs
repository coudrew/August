using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Calculator calculator = new Calculator();
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
    }

    protected void btn0Click()
    {
        lblDisplayScreen.Text = calculator.updateDisplay(btn0.Text);
    }
}