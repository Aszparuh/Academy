namespace ASP.MVC.Essentials.Web.Areas.Calculator.Controllers
{
    using System.Diagnostics;
    using Models;
    using System.Web.Mvc;
    using System.Collections.Generic;

    using Infrastructure;

    public class CalculatorController : Controller
    {
        static readonly IList<Unit> Units = new List<Unit>()
        {
            new Unit { UnitType = UnitType.Bit },
            new Unit { UnitType = UnitType.Byte },
            new Unit { UnitType = UnitType.Kilobit },
            new Unit { UnitType = UnitType.Kilobyte },
            new Unit { UnitType = UnitType.Megabit },
            new Unit { UnitType = UnitType.Megabyte },
            new Unit { UnitType = UnitType.Gigabit },
            new Unit { UnitType = UnitType.Gigabyte },
            new Unit { UnitType = UnitType.Terabit },
            new Unit { UnitType = UnitType.Terabyte },
            new Unit { UnitType = UnitType.Petabit },
            new Unit { UnitType = UnitType.Petabyte },
            new Unit { UnitType = UnitType.Exabit },
            new Unit { UnitType = UnitType.Exabyte },
            new Unit { UnitType = UnitType.Zettabit },
            new Unit { UnitType = UnitType.Zettabyte },
            new Unit { UnitType = UnitType.Yottabit },
            new Unit { UnitType = UnitType.Yottabyte }
        };

        // GET: Calculator/Calculator
        [HttpGet]
        public ActionResult Index()
        {
            var calculator = new BitCalculator();
            var calculatorViewModel = new BitCalculatorViewModel();
            calculatorViewModel.Quantity = "1";

            foreach (var unit in Units)
            {
                unit.Value = calculator.Calculate((int)unit.UnitType, 1024, "1");
            }

            calculatorViewModel.Units = Units;
            return View(calculatorViewModel);
        }

        [HttpPost]
        public ActionResult Index(BitCalculatorViewModel model)
        {
            var calculator = new BitCalculator();
            var bits = calculator.ConvertToBits(model.Quantity, (int)model.UnitType, (int)model.KiloValue);

            foreach (var unit in Units)
            {
                unit.Value = calculator.Calculate((int)unit.UnitType, (int)model.KiloValue, bits);
            }

            model.Units = Units;

            return View(model);
        }
    }
}