namespace Movies.Web.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data.Contracts;
    using ViewModels.Movies;

    public class MoviesController : BaseController
    {
        private readonly IActorService actors;
        private readonly IMovieService movies;
        private readonly IStudioService studios;

        public MoviesController(IActorService actors, IMovieService movies, IStudioService studios)
        {
            this.actors = actors;
            this.movies = movies;
            this.studios = studios;
        }

        [HttpGet]
        public ActionResult CreateMovie()
        {
            var viewModel = new CreateMovieViewModel();
            viewModel.FemaleActors = this.actors.GetAllFemale().Select(a => new SelectListItem() { Text = a.Name, Value = a.Id.ToString() });
            viewModel.MaleActors = this.actors.GetAllMale().Select(a => new SelectListItem() { Text = a.Name, Value = a.Id.ToString() });
            viewModel.Studios = this.studios.GetAll().Select(s => new SelectListItem() { Text = s.StudioName, Value = s.Id.ToString() });
            return this.PartialView("_CreateMovie", viewModel);
        }

        [HttpPost]
        public ActionResult CreateMovie(CreateMovieViewModel input)
        {
            if (this.ModelState.IsValid)
            {
                var movieToSave = this.Mapper.Map<Movie>(input);

                // var maleActor = this.actors
                //    .GetAllMale()
                //    .Include(a => a.Movies)
                //    .FirstOrDefault(a => a.Id == input.MaleActorId);

                // var femaleActor = this.actors
                //    .GetAllFemale()
                //    .Include(a => a.Movies)
                //    .FirstOrDefault(a => a.Id == input.FemaleActorId);
                var maleActor = this.actors.GetById(input.MaleActorId);
                var femaleActor = this.actors.GetById(input.FemaleActorId);

                movieToSave.Actors.Add(maleActor);
                movieToSave.Actors.Add(femaleActor);

                // this also works
                // maleActor.Movies.Add(movieToSave);
                // femaleActor.Movies.Add(movieToSave);
                this.movies.Add(movieToSave);
                return this.RedirectToAction("Index", "Home");
            }

            return this.PartialView("_CreateMovie", input);
        }
    }
}