using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Superhero
    {
        private ICollection<Power> powers;
        private ICollection<Fraction> fractions;
        private ICollection<Relationship> relations;

        public Superhero()
        {
            this.powers = new HashSet<Power>();
            this.fractions = new HashSet<Fraction>();
            this.relations = new HashSet<Relationship>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 symbols")]
        [MaxLength(60, ErrorMessage = "Name cannot be larger than 60 symbols")]
        public string Name { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "SecretIdentity cannot be less than 3 symbols")]
        [MaxLength(20, ErrorMessage = "SecretIdentity cannot be larger than 20 symbols")]
        [Index(IsUnique = true)]
        public string SecretIdentity { get; set; }

        [Required(ErrorMessage = "Alignment is reqiured")]
        public Alignment Alignment { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Story { get; set; }

        public virtual ICollection<Power> Powers
        {
            get
            {
                return this.powers;
            }

            set
            {
                this.powers = value;
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

        [InverseProperty("Superhero")]
        public virtual ICollection<Relationship> Relationships
        {
            get
            {
                return this.relations;
            }

            set
            {
                this.relations = value;
            }
        }

        public int CityId { get; set; }

        public virtual City City { get; set; }

    }
}
