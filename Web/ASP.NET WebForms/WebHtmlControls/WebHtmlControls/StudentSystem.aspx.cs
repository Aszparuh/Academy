using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHtmlControls
{
    public partial class StudentSystem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Command(object sender, CommandEventArgs e)
        {
            string firstName = this.tbFirstName.Text;
            string lastName = this.tbLastName.Text;
            string facultyNumber = this.tbStudentNumber.Text;
            string university = this.ddlUniversity.SelectedValue;
            string list = "<ul>";
            foreach (ListItem item in this.ddlCourses.Items)
            {
                if (item.Selected)
                {
                    list += "<li><strong>" + Server.HtmlEncode(item.Text) + "</strong></li>";
                }
            }
            list += "</ul>";
            this.result.Text = "";
            this.result.Text += "<h3>" + Server.HtmlEncode(firstName) + " " + Server.HtmlEncode(lastName) + "</h3>";
            this.result.Text += "<p> With faculty number <strong>" + Server.HtmlEncode(facultyNumber) + "</strong></p>";
            this.result.Text += "<p> From <strong>" + Server.HtmlEncode(university) + "</strong></p>";
            this.result.Text += "<p> The student is enrolled for: " + list + "</p>";
        }
    }
}