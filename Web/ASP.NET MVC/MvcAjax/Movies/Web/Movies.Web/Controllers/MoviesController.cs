namespace Movies.Web.Controllers
{
    using System.Web.Mvc;

    public class MoviesController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return this.PartialView("_Create");
        }
    }
}