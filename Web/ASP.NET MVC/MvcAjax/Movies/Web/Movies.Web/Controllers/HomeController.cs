namespace Movies.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Infrastructure.Mappings;
    using Services.Data.Contracts;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private const int ItemsPerPage = 10;

        private IMovieService movies;

        public HomeController(IMovieService movies)
        {
            this.movies = movies;
        }

        public ActionResult Index(int id = 1)
        {
            var page = id;
            var allMoviesCount = this.movies.GetAll().Count();
            var totalPages = (int)Math.Ceiling(allMoviesCount / (decimal)ItemsPerPage);
            var moviesToSkip = (page - 1) * ItemsPerPage;
            var movies = this.movies.GetAll()
                .OrderBy(x => x.Title)
                .ThenBy(x => x.Id)
                .Skip(moviesToSkip).Take(ItemsPerPage)
                .To<MovieViewModel>().ToList();

            var viewModel = new PagableListMovieViewModel
            {
                CurrentPage = page,
                TotalPages = totalPages,
                Movies = movies
            };

            return this.View(viewModel);
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}