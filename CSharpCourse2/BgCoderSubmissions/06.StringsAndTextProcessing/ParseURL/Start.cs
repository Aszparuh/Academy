namespace ParseURL
{
    using System;

    class Start
    {
        static void Main()
        {
            string inputUrl = Console.ReadLine();
            int indexOfColumn = inputUrl.IndexOf(':');
            Console.WriteLine(string.Format("[protocol] = {0}", inputUrl.Substring(0, indexOfColumn)));
            int startOfServer = indexOfColumn + 3;
            int endOfServer = inputUrl.IndexOf('/', startOfServer);
            Console.WriteLine(string.Format("[server] = {0}", inputUrl.Substring(startOfServer, endOfServer - startOfServer)));
            Console.WriteLine(string.Format("[resource] = {0}", inputUrl.Substring(endOfServer)));

            //[protocol] = https
            //[server] = github.com
            //[resource] = /gentoo/gentoo.git
    }
    }
}
