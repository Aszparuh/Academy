using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsSumatorConverter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox firstTextBox = this.tbFirst;
            TextBox secondTextBox = this.tbSecond;
            Button sumButton = this.sumButton;

            firstTextBox.Attributes["placeholder"] = "Enter number";
            firstTextBox.Attributes["class"] = "form-control";
            firstTextBox.Attributes["type"] = "number";

            secondTextBox.Attributes["placeholder"] = "Enter number";
            secondTextBox.Attributes["class"] = "form-control";
            secondTextBox.Attributes["type"] = "number";

            sumButton.Attributes["class"] = "btn btn-default";
            sumButton.Text = "Sum";
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            var result = this.result;
            var firstNumber = double.Parse(this.tbFirst.Text);
            var secondNumber = double.Parse(this.tbSecond.Text);
            var sum = firstNumber + secondNumber;

            result.Text = string.Format("{0} + {1} = {2}", firstNumber, secondNumber, sum);
        }
    }
}