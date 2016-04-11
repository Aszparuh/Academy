namespace MvcEssentials.Services.Data
{
    using MvcEssentials.Data.Models;
    using System.Linq;

    public interface IRegionsService
    {
        IQueryable<Region> GetAll();
    }
}
