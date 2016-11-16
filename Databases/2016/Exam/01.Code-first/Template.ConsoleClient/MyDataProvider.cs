using System;
using Template.Data.Common;
using Template.Models;

namespace Template.ConsoleClient
{
    public class MyDataProvider
    {
        public IRepository<Superhero> superheroes;
        public IRepository<Power> powers;
        public IRepository<City> cities;
        public IRepository<Country> countries;
        public IRepository<Planet> planets;
        public IRepository<Fraction> fractions;
        public Func<IUnitOfWork> unitOfWork;

        public MyDataProvider(
            Func<IUnitOfWork> unitOfWork,
            IRepository<Superhero> superheroes,
            IRepository<Power> powers,
            IRepository<City> cities,
            IRepository<Country> countries,
            IRepository<Planet> planets,
            IRepository<Fraction> fractions)
        {
            this.superheroes = superheroes;
            this.powers = powers;
            this.unitOfWork = unitOfWork;
            this.cities = cities;
            this.countries = countries;
            this.planets = planets;
            this.fractions = fractions;
        }
    }
}
