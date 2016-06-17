namespace Movies.Web.Controllers
{
    using System.Web.Mvc;

    public class MoviesController : Controller
    {
        [HttpGet]
        [ChildActionOnly]
        public ActionResult Create()
        {
            return this.PartialView();
        }
    }
}