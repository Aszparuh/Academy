namespace ASP.MVC.EssentialsHomework.Areas.Calculator.Controllers
{
    using Models;
    using System.Web.Mvc;

    public class CalculatorController : Controller
    {
        // GET: Calculator/Calculator
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BitCalculatorViewModel model)
        {
            return View();
        }
    }
}