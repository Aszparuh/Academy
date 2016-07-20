namespace Movies.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class PagableListMovieViewModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public IEnumerable<MovieViewModel> Movies { get; set; }
    }
}