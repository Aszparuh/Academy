namespace ReplaceTags
{
    using System;
    using System.Text;

    /*Write a program that replaces in a HTML document given as string all 
     * the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

    class Replace
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            //string text = Console.ReadLine();
            string text = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
           
            StringBuilder sb = new StringBuilder(text);
            sb.Replace("<a href=\"", "[URL=");
            sb.Replace("\">", "]");
            sb.Replace("</a>", "[/URL]");

            Console.WriteLine(sb);
        }
    }
}
