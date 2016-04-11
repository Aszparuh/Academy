namespace MVC.Essentials.Services.Data
{
    using MVC.Essentials.Data.Models;
    using System.Linq;

    public interface IRegionsService
    {
        IQueryable<Region> GetAll();
    }
}
