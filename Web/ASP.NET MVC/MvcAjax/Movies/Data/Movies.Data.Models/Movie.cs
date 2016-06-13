namespace Movies.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Movies.Data.Common.Models;

    public class Movie : BaseModel<int>
    {
        private ICollection<Actor> actors;

        public Movie()
        {
            this.actors = new HashSet<Actor>();
        }

        [Display(Name = "Title")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Movie title should be between 1 and 200 chars.")]
        public string Title { get; set; }

        [Display(Name = "Year")]
        [Range(1900, 2016, ErrorMessage = "Movie year should be after 1900 year.")]
        public int Year { get; set; }

        [Display(Name = "Studio name")]
        public string StudioName { get; set; }

        [Display(Name = "Studio address")]
        public string StudioAddress { get; set; }

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
