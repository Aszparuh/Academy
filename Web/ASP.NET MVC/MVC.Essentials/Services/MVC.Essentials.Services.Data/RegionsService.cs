namespace MVC.Essentials.Services.Data
{
    using System.Linq;

    using Essentials.Data.Models;
    using Essentials.Data.Common;

    public class RegionsService : IRegionsService
    {
        private readonly IDbRepository<Region> regions;

        public RegionsService(IDbRepository<Region> regions)
        {
            this.regions = regions;
        }

        public IQueryable<Region> GetAll()
        {
            return this.regions.All().OrderBy(r => r.Name);
        }
    }
}
