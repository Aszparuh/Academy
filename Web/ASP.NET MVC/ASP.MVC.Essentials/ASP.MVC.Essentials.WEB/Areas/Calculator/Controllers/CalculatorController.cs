namespace ASP.MVC.EssentialsHomework.Areas.Calculator.Controllers
{
    using System.Diagnostics;
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
            Trace.WriteLine(model.KiloValue.ToString());
            Trace.WriteLine(model.UnitType.ToString());
            Trace.WriteLine(model.KiloValue + 6);
            return View();
        }
    }
}