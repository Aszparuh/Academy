namespace Movies.Web.ViewModels.Movies
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using Infrastructure.Mappings;

    public class CreateMovieViewModel : IMapTo<Movie>
    {
        private ICollection<Actor> actors;

        public CreateMovieViewModel()
        {
            this.actors = new HashSet<Actor>();
        }

        [Required]
        [Display(Name = "Title")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Movie title should be between 1 and 200 chars.")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Describtion has to be less than 2000 symbols.")]
        public string MovieDesciption { get; set; }

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

        [Display(Name = "Female Actors")]
        public ICollection<Actor> FemaleActors { get; set; }

        [Display(Name = "Male Actors")]
        public ICollection<Actor> MaleActors { get; set; }
    }
}