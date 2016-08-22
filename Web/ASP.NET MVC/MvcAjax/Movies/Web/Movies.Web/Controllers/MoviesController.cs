namespace Movies.Web.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using Data.Models;
    using Infrastructure.Mappings;
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

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return this.HttpNotFound();
            }

            var movie = this.movies.GetByIdWithActorsAsQueryable((int)id).To<MovieDetailsViewModel>().FirstOrDefault();
            return this.PartialView("_DetailsMovie", movie);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return this.HttpNotFound();
            }

            var movie = this.movies.GetByIdWithActorsAsQueryable((int)id).To<CreateMovieViewModel>().FirstOrDefault();

            movie.FemaleActors = this.actors.GetAllFemale().Select(a => new SelectListItem() { Text = a.Name, Value = a.Id.ToString() });
            movie.MaleActors = this.actors.GetAllMale().Select(a => new SelectListItem() { Text = a.Name, Value = a.Id.ToString() });
            movie.Studios = this.studios.GetAll().Select(s => new SelectListItem() { Text = s.StudioName, Value = s.Id.ToString() });

            return this.PartialView("_UpdateMovie", movie);
        }

        [HttpPost]
        public ActionResult Edit(CreateMovieViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                // var movieToEdit = this.movies.GetAll().Where(m => m.Id == model.Id).Include(m => m.Actors).FirstOrDefault();
                // var actors = this.actors.GetAll().Where(x => x.Id == model.MaleActorId || x.Id == model.FemaleActorId);

                // movieToEdit.Title = model.Title;
                // movieToEdit.MovieDesciption = model.MovieDesciption;
                // movieToEdit.Year = model.Year;
                // movieToEdit.Actors = new List<Actor>(actors);
                // movieToEdit.StudioId = model.StudioId;

                // this.movies.Save();
                var existingMovie = this.movies.GetByIdWithActors(model.Id);
                var movieToEdit = this.Mapper.Map<CreateMovieViewModel, Movie>(model, existingMovie);
                var actors = this.actors.GetAll().Where(x => x.Id == model.MaleActorId || x.Id == model.FemaleActorId);
                this.movies.Edit(movieToEdit, actors);

                return this.RedirectToAction("Index", "Home");
            }

            return this.PartialView("_UpdateMovie", model);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                this.movies.Hide((int)id);
                return this.RedirectToAction("Index", "Home");
            }
            else
            {
                return this.HttpNotFound();
            }
        }
    }
}