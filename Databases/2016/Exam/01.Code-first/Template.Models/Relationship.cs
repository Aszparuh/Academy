using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models
{
    public class Relationship
    {
        public int Id { get; set; }

        public RelationshipType RelationShipType { get; set; }

        public int SuperheroId { get; set; }

        [ForeignKey("SuperheroId")]
        public virtual Superhero Superhero { get; set; }

        public int? ToSuperheroId { get; set; }

        [ForeignKey("ToSuperheroId")]
        public virtual Superhero ToSuperhero { get; set; }
    }
}
