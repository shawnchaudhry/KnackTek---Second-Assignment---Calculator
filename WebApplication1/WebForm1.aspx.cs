using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public double add(double arg0, double arg1)
        {
            double arg2 = arg0 + arg1;
            return arg2;
        }

        public double subtract(double arg0, double arg1)
        {
            double arg2 = arg0 - arg1;
            return arg2;
        }
        public double multiply(double arg0, double arg1)
        {
            double arg2 = arg0 * arg1;
            return arg2;
        }
        public double divide(double arg0, double arg1)
        {
            if (arg1 > 0)
            {
                double arg2 = arg0 / arg1;
                return arg2;
            }
            else
            {
                lblAnswer.Text = "You cannot divide by 0.";
                double arg2 = 0;
                return arg2;
            }
        }

        public void finish(Object Sender, EventArgs e)
        {
            String answer = "";
            try
            {
                Double arg0 = Double.Parse(tbOne.Text);
                Double arg1 = Double.Parse(tbTwo.Text);

                if (rblOperations.SelectedValue.CompareTo("Add") == 0)
                {
                    answer = "" + add(arg0, arg1);
                }

                if (rblOperations.SelectedValue.CompareTo("Subtract") == 0)
                {
                    answer = "" + subtract(arg0, arg1);
                }

                if (rblOperations.SelectedValue.CompareTo("Multiply") == 0)
                {
                    answer = "" + multiply(arg0, arg1);
                }

                if (rblOperations.SelectedValue.CompareTo("Divide") == 0)
                {
                    answer = "" + divide(arg0, arg1);
                }

                Label answerLabel = new Label();
                answerLabel.Text = answer;
                Page.Controls.Add(answerLabel);
            }
            catch (FormatException)
            {
                lblAnswer.Text = "Please input a number!";
            }
        }
    }
}