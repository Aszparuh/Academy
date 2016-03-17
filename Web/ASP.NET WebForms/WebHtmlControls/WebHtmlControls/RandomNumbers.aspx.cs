using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHtmlControls
{
    public partial class RandomNumber : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.btnGenerate.Click += new EventHandler(button_ServerClick);
            this.tbFrom.Attributes["type"] = "number";
            this.tbTo.Attributes["type"] = "number";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_ServerClick(object sender, EventArgs e)
        {
            int from;
            int to;
            string fromString;
            string toString;

            if (sender is Button)
            {
                fromString = this.tbFrom.Text;
                toString = this.tbTo.Text;
            }
            else
            {
                fromString = this.from.Value;
                toString = this.to.Value;
            }

            if (string.IsNullOrEmpty(fromString))
            {
                from = int.MinValue;
            }
            else
            {
                from = int.Parse(fromString);
            }

            if (string.IsNullOrEmpty(toString))
            {
                to = int.MaxValue;
            }
            else
            {
                to = int.Parse(toString);
            }

            var result = GenerateRandom(from, to);
            this.generated.Value = result.ToString();
            this.result.Text = result.ToString();
        }

        private int GenerateRandom(int from, int to)
        {
            if (from > to)
            {
                int temp = to;
                to = from;
                from = temp;
            }

            var Random = new Random();
            return Random.Next(from, to);
        }
    }
}