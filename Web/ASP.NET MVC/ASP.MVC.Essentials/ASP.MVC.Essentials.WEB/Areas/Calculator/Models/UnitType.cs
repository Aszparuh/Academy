namespace ASP.MVC.Essentials.Web.Areas.Calculator.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum UnitType
    {
        [Display(Name = "Bit-b")]
        Bit,
        [Display(Name = "Byte-B")]
        Byte,
        [Display(Name = "Kilobit-Kb")]
        Kilobit,
        [Display(Name = "Kilobyte-KB")]
        Kilobyte,
        [Display(Name = "Megabit-Mb")]
        Megabit,
        [Display(Name = "Megabyte-MB")]
        Megabyte,
        [Display(Name = "Gigabit-Gb")]
        Gigabit,
        [Display(Name = "Gigabyte-GB")]
        Gigabyte,
        [Display(Name = "Terabit-Tb")]
        Terabit,
        [Display(Name = "Terabyte-TB")]
        Terabyte,
        [Display(Name = "Petabit-Pb")]
        Petabit,
        [Display(Name = "Petabyte-PB")]
        Petabyte,
        [Display(Name = "Exabit-Eb")]
        Exabit,
        [Display(Name = "Exabyte-EB")]
        Exabyte,
        [Display(Name = "Zettabit-Zb")]
        Zettabit,
        [Display(Name = "Zettabyte-ZB")]
        Zettabyte,
        [Display(Name = "Yottabit-Yb")]
        Yottabit,
        [Display(Name = "Yottabyte-YB")]
        Yottabyte
    }
}