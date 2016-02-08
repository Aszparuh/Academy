namespace Tasks.Controllers
{
    using Models;
    using System.Web.Mvc;

    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Values model = new Values();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Values model)
        {
            var input = model.Input;

            model.Byte = input / 8;
            return View(model);
        }
    }
}