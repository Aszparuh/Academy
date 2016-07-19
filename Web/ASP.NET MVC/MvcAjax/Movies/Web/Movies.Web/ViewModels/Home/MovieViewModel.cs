namespace Movies.Web.ViewModels.Home
{
    using Data.Models;
    using Infrastructure.Mappings;

    public class MovieViewModel : IMapFrom<Movie>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }
    }
}