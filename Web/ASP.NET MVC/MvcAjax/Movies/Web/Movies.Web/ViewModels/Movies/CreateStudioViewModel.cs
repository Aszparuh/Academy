namespace Movies.Web.ViewModels.Movies
{
    using System.ComponentModel.DataAnnotations;
    using Data.Models;
    using Infrastructure.Mappings;

    public class CreateStudioViewModel : IMapTo<Studio>
    {
        [Required]
        [Display(Name = "Studio Name")]
        [MaxLength(200, ErrorMessage = "Studio name should not be longer that 200 chars")]
        public string StudioName { get; set; }

        [Required]
        [Display(Name = "Studio Address")]
        [MaxLength(500, ErrorMessage = "Studio address should not be longer that 500 chars")]
        public string StudioAddress { get; set; }
    }
}