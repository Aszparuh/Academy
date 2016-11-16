using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Country
    {
        private ICollection<City> cities;

        public Country()
        {
            this.cities = new HashSet<City>();
        }

        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "Country Name must be longer than 2 symbols")]
        [MaxLength(30, ErrorMessage = "Country Name cannot be longer than 30 symbols")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities
        {
            get
            {
                return this.cities;
            }

            set
            {
                this.cities = value;
            }
        }

        public int PlanetId { get; set; }

        public virtual Planet Planet { get; set; }
    }
}
