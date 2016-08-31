using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Calculator
/// </summary>
public class Calculator
{
    int displayState; //0-new output 1-concat to current output
    String displayOutput; //what screen is currently showing
    String leftOperand; //LHS of current operation
    String rightOperand; //RHS of current operation
    String currentOperator; //current operation to perform

    public Calculator()
    {
        this.displayState = 0;
        this.displayOutput = "";
    }

    public String updateDisplay(String data)
    {
        if (this.displayState == 0)
        {
            this.displayOutput = data;
            this.displayState = 1;
        }
        else if (this.displayState == 1)
        {
            this.displayOutput += data;
        }
        return this.displayOutput;
    }
}