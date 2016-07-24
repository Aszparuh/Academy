namespace Movies.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Movies.Data.Common.Models;

    public class Studio : BaseModel<int>
    {
        private ICollection<Movie> movies;

        public Studio()
        {
            this.movies = new HashSet<Movie>();
        }

        [Required]
        [MaxLength(200, ErrorMessage = "Studio name should not be longer that 200 chars")]
        public string StudioName { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Studio address should not be longer that 500 chars")]
        public string StudioAddress { get; set; }

        public ICollection<Movie> Movies
        {
            get
            {
                return this.movies;
            }

            set
            {
                this.movies = value;
            }
        }
    }
}
