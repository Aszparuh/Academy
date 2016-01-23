namespace HelloApp
{
    using System;
    using System.Web.UI;

    public partial class Index : Page
    {

        protected void Page_PreInit(object sender, EventArgs e)
        {
            AddParagraph("Page_PreInit invoked");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            AddParagraph("Page_Init invoked");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            AddParagraph("Page_InitComplete invoked");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            AddParagraph("Page_PreLoad invoked");
        }

        protected void Page_ControlEvents(object sender, EventArgs e)
        {
            AddParagraph("Page_ControlEvents invoked");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            AddParagraph("Page_PreRender invoked");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            AddParagraph("Page_PreRenderComplete invoked");
        }

        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            AddParagraph("Page_SaveStateComplete invoked");
        }

        protected void Page_RenderComplete(object sender, EventArgs e)
        {
            AddParagraph("Page_RenderComplete invoked");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            AddParagraph("Page_LoadComplete invoked");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            AddParagraph("Page_Load invoked");
        }

        protected void OnButtonClick(object sender, EventArgs e)
        {
            AddParagraph("OnButtonClick invoked");
            this.span.InnerText = "Hello " + this.tb.Value;
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            AddParagraph("Page_Unload invoked");
        }

        private void AddParagraph(string text)
        {
            string nextParagraph = string.Format("<p>{0}</p>", text);
            this.div.InnerHtml += nextParagraph;
        }
    }
}