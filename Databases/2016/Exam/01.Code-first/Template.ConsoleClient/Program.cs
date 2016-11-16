using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using Ninject;
using Template.ConsoleClient.Models;
using Template.Data;
using Template.Data.Migrations;
using Newtonsoft.Json;
using Template.Data.Common;
using System.Data.Entity.Migrations;

namespace Template.ConsoleClient
{
    public class Program
    {
        public static void Main()
        {
            IKernel kernel = BootstrapNinject();
            MyDataProvider dp = kernel.Get<MyDataProvider>();
            Import();
        }

        private static IKernel BootstrapNinject()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }

        private static void Import()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TemplateDbContext, Configuration>());

            var heroes = new List<Superhero>();

            var files = Directory.GetFiles(Environment.CurrentDirectory).Where(fileName => fileName.EndsWith(".json")).ToList();

            foreach (var file in files)
            {
                var fileContent = File.ReadAllText(file);              
                var result = JsonConvert.DeserializeObject<RootObject>(fileContent);
                heroes.AddRange(result.Heroes);
                Console.WriteLine("{0} read.", file);
            }

            var cityNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var countryNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var planetNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var powerNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var fractionNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var hero in heroes)
            {
                cityNames.Add(hero.City.Name);
                countryNames.Add(hero.City.Country);
                planetNames.Add(hero.City.Planet);

                foreach (var power in hero.Powers)
                {
                    powerNames.Add(power);
                }

                if (hero.Fractions != null)
                {
                    foreach (var fraction in hero.Fractions)
                    {
                        fractionNames.Add(fraction);
                    }
                }
                
            }

            var database = new MyDataProvider();
            var unitOfWork = new EfUnitOfWork(database);

            Console.WriteLine("Adding cities");
            using (unitOfWork)
            {
                foreach (var planetName in planetNames)
                {
                    database.Planets.Add( new Template.Models.Planet() { Name = planetName });
                }

                foreach (var countryName in countryNames)
                {
                    database.Countries.Add( new Template.Models.Country() { Name = countryName });
                }

                foreach (var cityName in cityNames)
                {
                    database.Cities.Add( new Template.Models.City() { Name = cityName });
                }

                foreach (var powerName in powerNames)
                {
                    database.Powers.Add( new Template.Models.Power() { Name = powerName });
                }

                foreach (var fractionName in fractionNames)
                {
                    database.Fractions.Add( new Template.Models.Fraction() { Name = fractionName });
                }

                unitOfWork.Commit();
            }

            using (unitOfWork)
            {
                foreach (var hero in heroes)
                {
                    var currentCity = database.Cities.FirstOrDefault(c => c.Name == hero.City.Name);
                    var currentPlanet = database.Planets.FirstOrDefault(p => p.Name == hero.City.Planet);
                    var currentCountry = database.Countries.FirstOrDefault(c => c.Name == hero.City.Country);

                    currentCountry.Cities.Add(currentCity);
                    currentPlanet.Countries.Add(currentCountry);
                    

                    var currentPowers = new List<Template.Models.Power>();

                    foreach (var power in hero.Powers)
                    {
                        currentPowers.Add(database.Powers.Where(p => p.Name == power).Single());
                    }

                    var currentFractions = new List<Template.Models.Fraction>();

                    foreach (var fraction in hero.Fractions)
                    {
                        currentFractions.Add(database.Fractions.Where(f => f.Name == fraction).Single());
                    }

                    var superhero = new Template.Models.Superhero()
                    {
                        Name = hero.Name,
                        SecretIdentity = hero.SecretIdentity,
                        City = currentCity,
                        Alignment = hero.Alignment,
                        Story = hero.Story,
                        Powers = currentPowers,
                        Fractions = currentFractions
                    };

                    database.Superheroes.Add(superhero);
                    unitOfWork.Commit();
                }

            }

            Console.WriteLine();
        }
    }
}
