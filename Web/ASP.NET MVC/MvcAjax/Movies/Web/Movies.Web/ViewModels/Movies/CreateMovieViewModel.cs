namespace Movies.Web.ViewModels.Movies
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Data.Models;
    using Infrastructure.Mappings;

    public class CreateMovieViewModel : IMapTo<Movie>
    {
        [Required]
        [Display(Name = "Title")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Movie title should be between 1 and 200 chars.")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Describtion has to be less than 2000 symbols.")]
        public string MovieDesciption { get; set; }

        [Display(Name = "Female Actors")]
        public IEnumerable<SelectListItem> FemaleActors { get; set; }

        public int FemaleActorId { get; set; }

        [Display(Name = "Male Actors")]
        public IEnumerable<SelectListItem> MaleActors { get; set; }

        public int MaleActorId { get; set; }
    }
}