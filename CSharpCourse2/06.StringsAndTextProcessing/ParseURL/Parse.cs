namespace ParseURL
{
    using System;

    /*Write a program that parses an URL address given in the format: 
     [protocol]://[server]/[resource] and extracts from it the [protocol], 
     [server] and [resource] elements.
        Example:

        URL	Information
        http://telerikacademy.com/Courses/Courses/Details/212	
        [protocol] = http 
        [server] = telerikacademy.com 
        [resource] = /Courses/Courses/Details/212*/

    class Parse
    {
        static void GetProtServPath(string url)
        {
            Console.WriteLine("[URL] = {0}", url);
            int protocolIndex = url.IndexOf("://");
            string protocol = url.Substring(0, protocolIndex);
            Console.WriteLine("[protocol] = {0}", protocol);
            int serverIndex = url.IndexOf("/", protocolIndex + 3);
            string server = url.Substring(protocolIndex + 3, serverIndex - protocolIndex - 3);
            Console.WriteLine("[server] = {0}", server);
            string resource = url.Substring(serverIndex);
            Console.WriteLine("[resource] = {0}", resource);
        }

        static void Main()
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();
            GetProtServPath(url);
        }
    }
}