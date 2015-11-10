namespace PrintOrderedStudents
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var dictionary = new SortedDictionary<string, List<Student>>();
            var path = @"../../students.txt";
            using (var reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    var splitedLine = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var key = splitedLine[2];
                    var firstName = splitedLine[0];
                    var lastName = splitedLine[1];

                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key].Add(new Student(firstName, lastName));
                    }
                    else
                    {
                        dictionary.Add(key, new List<Student> { new Student(firstName, lastName) });
                    }
                }
            }

            foreach (var element in dictionary)
            {
                var course = element.Key;
                var students = element.Value.OrderBy(st => st.LastName)
                                            .ThenBy(st => st.FirstName)
                                            .ToList();
                Console.Write(course);
                Console.Write(" ");
                Console.WriteLine(string.Join(", ", students));
            }
        }
    }
}