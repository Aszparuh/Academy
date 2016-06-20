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

        [Required]
        [Range(1900, 2016, ErrorMessage = "Movie year should be after 1900 year.")]
        public int Year { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Studio name should not be longer that 200 chars")]
        public string StudioName { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Studio address should not be longer that 500 chars")]
        public string StudioAddress { get; set; }

        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Describtion has to be less than 2000 symbols.")]
        public string MovieDesciption { get; set; }

        public IEnumerable<SelectListItem> FemaleActors { get; set; }

        [Display(Name = "Actress")]
        public int FemaleActorId { get; set; }

        public IEnumerable<SelectListItem> MaleActors { get; set; }

        [Display(Name = "Actor")]
        public int MaleActorId { get; set; }
    }
}