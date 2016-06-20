namespace Movies.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Services.Data.Contracts;
    using ViewModels.Movies;

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
            var viewModel = new CreateMovieViewModel();
            viewModel.FemaleActors = this.actors.GetAllFemale().Select(a => new SelectListItem() { Text = a.Name, Value = a.Id.ToString() });
            viewModel.MaleActors = this.actors.GetAllMale().Select(a => new SelectListItem() { Text = a.Name, Value = a.Id.ToString() });
            return this.PartialView("_Create", viewModel);
        }
    }
}