namespace ASP.MVC.Essentials.Web.Areas.Calculator.Controllers
{
    using System.Diagnostics;
    using Models;
    using System.Web.Mvc;
    using System.Collections.Generic;

    public class CalculatorController : Controller
    {
        // GET: Calculator/Calculator
        [HttpGet]
        public ActionResult Index()
        {
            var unitsList = new List<Unit>();
            var firstUnit = new Unit { UnitType = UnitType.Byte, Value = "8" };
            unitsList.Add(firstUnit);

            var calcView = new BitCalculatorViewModel(unitsList);
            calcView.Quantity = "1";
            return View(calcView);
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