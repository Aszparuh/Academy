using System.Data.Entity;
using Template.Models;

namespace Template.Data
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext()
            :base("TemplateDbContext")
        {
        }

        public DbSet<Superhero> Superheroes { get; set; }

        public DbSet<Power> Powers { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Planet> Planets { get; set; }

        public DbSet<Fraction> Fractions { get; set; }

        public DbSet<Relationship> Relationships { get; set; }
    }
}
