namespace Movies.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Movies.Data.Common.Models;

    public class Actor : BaseModel<int>
    {
        private ICollection<Movie> movies;

        public Actor()
        {
            this.movies = new HashSet<Movie>();
        }

        [Display(Name = "Actor Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Actor name should be between 2 and 50 chars.")]
        public string Name { get; set; }

        [Display(Name = "Actor Age")]
        [Range(1, 120, ErrorMessage = "Actor age should be between 1 and 120 years")]
        public int Age { get; set; }

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
