using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Fraction
    {
        private ICollection<Planet> planets;
        private ICollection<Superhero> superheroes;

        public Fraction()
        {
            this.planets = new HashSet<Planet>();
            this.superheroes = new HashSet<Superhero>();
        }

        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "Fraction Name must be longer than 2 symbols")]
        [MaxLength(30, ErrorMessage = "Fraction Name cannot be longer than 30 symbols")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public Alignment Alignment { get; set; }

        public virtual ICollection<Planet> Planets
        {
            get
            {
                return this.planets;
            }

            set
            {
                this.planets = value;
            }
        }

        public virtual ICollection<Superhero> Superheroes
        {
            get
            {
                return this.superheroes;
            }

            set
            {
                this.superheroes = value;
            }
        }
    }
}
