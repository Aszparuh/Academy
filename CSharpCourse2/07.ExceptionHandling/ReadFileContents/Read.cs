namespace ReadFileContents
{
    using System;
    using System.IO;

    /*Write a program that enters file name along with its full file path 
      (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
      Find in MSDN how to use System.IO.File.ReadAllText(…).
      Be sure to catch all possible exceptions and print user-friendly error messages.*/

    class Read
    {
        static void Main()
        {
            //Console.Write("Enter file path and name: ");
            //string path = Console.ReadLine();
            string path = @"../../sample.txt";

            try
            {
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered empty file path.");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File with this name do not exist.");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("There is no such a directory");
            }
            catch(IOException)
            {
                Console.WriteLine("The file is opened in an other program");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("You are not authorized to use this file.");
            }
        }
    }
}