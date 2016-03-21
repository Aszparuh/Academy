namespace ASP.MVC.Essentials.Web.Areas.Calculator.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum KiloValue
    {
        [Display(Name = "1024")]
        HundredTwentyFour,
        [Display(Name = "1000")]
        Hundred
    }
}