using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Planet
    {
        private ICollection<Country> countries;
        private ICollection<Fraction> fractions;

        public Planet()
        {
            this.countries = new HashSet<Country>();
            this.fractions = new HashSet<Fraction>();
        }

        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "Planet Name must be longer than 2 symbols")]
        [MaxLength(30, ErrorMessage = "Planet Name cannot be longer than 30 symbols")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Country> Countries
        {
            get
            {
                return this.countries;
            }

            set
            {
                this.countries = value;
            }
        }

        public virtual ICollection<Fraction> Fractions
        {
            get
            {
                return this.fractions;
            }

            set
            {
                this.fractions = value;
            }
        }
    }
}
