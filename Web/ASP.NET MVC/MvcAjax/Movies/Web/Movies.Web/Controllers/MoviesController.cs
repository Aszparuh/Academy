namespace Movies.Web.Controllers
{
    using System.Web.Mvc;
    using Services.Data.Contracts;

    public class MoviesController : Controller
    {
        private readonly IActorService actors;
        private readonly IMovieService movies;

        public MoviesController(IActorService actors, IMovieService movies)
        {
            this.actors = actors;
            this.movies = movies;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.PartialView("_Create");
        }
    }
}