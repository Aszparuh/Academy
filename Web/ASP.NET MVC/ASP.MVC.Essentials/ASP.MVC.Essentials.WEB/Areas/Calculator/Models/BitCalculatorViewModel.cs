namespace ASP.MVC.Essentials.Web.Areas.Calculator.Models
{
    using System.Collections.Generic;

    public class BitCalculatorViewModel
    {
        private IEnumerable<Unit> units;

        public BitCalculatorViewModel()
        {

        }

        public BitCalculatorViewModel(IEnumerable<Unit> units)
        {
            this.units = units;
        }

        public string Quantity { get; set; }

        public UnitType UnitType { get; set; }

        public KiloValue KiloValue { get; set; }

        public IEnumerable<Unit> Units
        {
            get
            {
                return this.units;
            }
        }
    }
}