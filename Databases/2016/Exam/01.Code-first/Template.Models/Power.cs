using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Power
    {
        private ICollection<Superhero> superheroes;

        public Power()
        {
            this.superheroes = new HashSet<Superhero>();
        }

        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Power Name cannot be less than 3 symbols")]
        [MaxLength(35, ErrorMessage = "Power Name cannot be longer than 35 symbols")]
        [Index(IsUnique = true)]
        public string Name { get; set; }

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
