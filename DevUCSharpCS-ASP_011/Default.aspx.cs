﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ""; //this sets the label to empty in case there is a message in it from a previous equivalency check. If we 
            //didn't do this, the message would stay on the screen.
            //if (firstTextBox.Text == secondTextBox.Text)
            //{
            //    resultLabel.Text = "Yes! They're equivalent!";             
            //}
            //else
            //{
            //    resultLabel.Text = "Nope, they're not equivalent!";
            //}


            //checkbox
            //if (awesomeCheckBox.Checked)
            //{
            //    resultLabel.Text = "Yup, awesomeness detection confirmed!";
            //}
            //else
            //{
            //    resultLabel.Text = "Think again! Awesomeness definately detected from your general direction!";
            //}

            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "You must be from Chicago!";
            }
            else if (saladRadioButton.Checked)
            {
                resultLabel.Text = "You must be healthy!";
            }
            else (pbjRadioButton.Checked)
            {
                resultLabel.Text = "You must be a fun loving person!";
            }

            // removed the need for the last clause in the if, else if, else statment by making one of the radio
            //buttons checked by default

            //else
            //{
            //    resultLabel.Text = "Please select  one of the options.";
            //}
        }
    }
}