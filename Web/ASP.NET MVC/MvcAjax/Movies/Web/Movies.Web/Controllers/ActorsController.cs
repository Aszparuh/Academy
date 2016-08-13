namespace Movies.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data.Contracts;
    using ViewModels.Actors;

    public class ActorsController : BaseController
    {
        private readonly IActorService actors;

        public ActorsController(IActorService actors)
        {
            this.actors = actors;
        }

        [HttpGet]
        public ActionResult CreateActor()
        {
            var actorViewModel = new CreateActorViewModel();
            return this.PartialView("_CreateActor", actorViewModel);
        }

        [HttpPost]
        public ActionResult CreateActor(CreateActorViewModel input)
        {
            if (this.ModelState.IsValid)
            {
                var actorToSave = this.Mapper.Map<Actor>(input);
                this.actors.Add(actorToSave);
                return this.RedirectToAction("Index", "Home");
            }

            return this.PartialView("_CreateActor", input);
        }
    }
}