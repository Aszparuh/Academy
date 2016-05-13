namespace OlympicsAreComing
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class EntryPoint
    {
        static void Main()
        {
            var countriesList = new List<Country>();
            string line = Console.ReadLine();

            while (line != "report")
            {
                int indexOfSeparatorLine = line.IndexOf('|');
                string countryName = line.Substring(indexOfSeparatorLine + 1).Trim();
                string participantString = line.Substring(0, indexOfSeparatorLine).Trim();
                string participantName = Regex.Replace(participantString, @"\s+", " ");
                bool isInList = true;

                //Console.WriteLine(countryName);
                //Console.WriteLine(participantName);

                foreach (var country in countriesList)
                {
                    if (country.Name == countryName)
                    {
                        if (country.Participants.Contains(participantName))
                        {
                            country.Wins++;
                        }
                        else
                        {
                            country.Participants.Add(participantName);
                        }
                    }
                    else
                    {
                        isInList = false;
                    }
                }

                if (isInList)
                {
                    countriesList.Add(new Country { Name = countryName });
                }

                line = Console.ReadLine();
            }

            countriesList.OrderBy(c => c.Wins).ToList();

            foreach (var country in countriesList)
            {
                Console.WriteLine("{0} ({1} participants): {2}wins", country.Name, country.Participants.Count, country.Wins);
            }
        }
    }

    class Country
    {
        private List<string> participants = new List<string>();

        public string Name { get; set; }

        public List<string> Participants
        {
            get
            {
                return this.participants;
            }
            set
            {
                this.participants = value;
            }
        }

        public int Wins { get; set; }
    }
}
