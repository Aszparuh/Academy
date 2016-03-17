using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHtmlControls
{
    public partial class Escaping : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Display(Object sender, CommandEventArgs e)
        {
            this.tbOutput.Text = this.tbUserInput.Text;
            this.lbOutput.Text = Server.HtmlEncode(this.tbUserInput.Text);
        }
    }
}