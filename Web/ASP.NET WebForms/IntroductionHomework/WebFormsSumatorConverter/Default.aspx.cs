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
            TextBox convertorTextBox = this.tbTextToImg;
            Button sumButton = this.sumButton;
            Button convertorButton = this.convertorButton;

            firstTextBox.Attributes["placeholder"] = "Enter number";
            firstTextBox.Attributes["class"] = "form-control";
            firstTextBox.Attributes["type"] = "number";

            secondTextBox.Attributes["placeholder"] = "Enter number";
            secondTextBox.Attributes["class"] = "form-control";
            secondTextBox.Attributes["type"] = "number";

            convertorTextBox.Attributes["placeholder"] = "Enter text";
            convertorTextBox.Attributes["class"] = "form-control";

            sumButton.Attributes["class"] = "btn btn-default";
            sumButton.Text = "Sum";

            convertorButton.Attributes["class"] = "btn btn-default";
            convertorButton.Text = "Convert";

            var text = this.Request.Params["text"] ?? "Default";
            this.resultImage.ImageUrl = "TextToImageHandler.ashx?text=" + text;
        }

        protected void Btn_Sum_Click(object sender, EventArgs e)
        {
            var result = this.result;
            var firstNumber = double.Parse(this.tbFirst.Text);
            var secondNumber = double.Parse(this.tbSecond.Text);
            var sum = firstNumber + secondNumber;

            result.Text = string.Format("{0} + {1} = {2}", firstNumber, secondNumber, sum);
        }

        protected void RenderImageButtonClicked(object sender, EventArgs e)
        {
            string text = string.IsNullOrEmpty(this.tbTextToImg.Text) ? "Empty" : this.tbTextToImg.Text;
            this.resultImage.ImageUrl = "TextToImageHandler.ashx?text=" + HttpContext.Current.Server.UrlEncode(text);
        }
    }
}