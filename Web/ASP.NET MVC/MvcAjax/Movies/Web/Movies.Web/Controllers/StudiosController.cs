namespace Movies.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data.Contracts;
    using ViewModels.Studios;

    public class StudiosController : BaseController
    {
        private readonly IStudioService studios;

        public StudiosController(IStudioService studios)
        {
            this.studios = studios;
        }

        [HttpGet]
        public ActionResult CreateStudio()
        {
            var studioViewModel = new CreateStudioViewModel();
            return this.PartialView("_CreateStudio", studioViewModel);
        }

        [HttpPost]
        public ActionResult CreateStudio(CreateStudioViewModel input)
        {
            if (this.ModelState.IsValid)
            {
                var studioToSave = this.Mapper.Map<Studio>(input);
                this.studios.Add(studioToSave);
                return this.RedirectToAction("Index", "Home");
            }

            return this.PartialView("_CreateStudio", input);
        }
    }
}