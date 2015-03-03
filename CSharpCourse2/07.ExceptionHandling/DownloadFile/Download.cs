namespace DownloadFile
{
    using System;
    using System.IO;
    using System.Net;

    /*Write a program that downloads a file from Internet (e.g. Ninja image) and stores
      it the current directory.
      Find in Google how to download files in C#.
      Be sure to catch all exceptions and to free any used resources in the finally block.*/

    class Download
    {
        static void Main()
        {
            string sourcePath = @"http://telerikacademy.com/Content/Images/news-img01.png";
            string localFilePath = Path.GetFileName(sourcePath);

            WebClient webClient = new WebClient();

            using (webClient)
            {
                try
                {
                    webClient.DownloadFile(sourcePath, localFilePath);
                    Console.WriteLine("File has been downloaded.");
                }
                catch (WebException exception)
                {
                    Console.Write(exception.Message);
                    if (exception.InnerException != null)
                    {
                        Console.WriteLine(" " + exception.InnerException.Message);
                    }
                    else
                        Console.WriteLine();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Erorr {0}", exception.InnerException.Message);
                }
            }
        }
    }
}