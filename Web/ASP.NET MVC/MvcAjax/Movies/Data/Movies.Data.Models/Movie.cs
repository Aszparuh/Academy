namespace Movies.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Movies.Data.Common.Models;

    public class Movie : BaseModel<int>
    {
        private ICollection<Actor> actors;

        public Movie()
        {
            this.actors = new HashSet<Actor>();
        }

        [Required]
        [MaxLength(200, ErrorMessage = "Movie title should be between 1 and 200 chars.")]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2016, ErrorMessage = "Movie year should be after 1900 year.")]
        public int Year { get; set; }

        [Required]
        [MaxLength(2000, ErrorMessage = "Description has to be less than 2000 symbols.")]
        public string MovieDesciption { get; set; }

        public int StudioId { get; set; }

        [ForeignKey("StudioId")]
        public virtual Studio Studio { get; set; }

        public ICollection<Actor> Actors
        {
            get
            {
                return this.actors;
            }

            set
            {
                this.actors = value;
            }
        }
    }
}
