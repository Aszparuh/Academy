namespace MvcEssentials.Services.Data
{
    using System.Linq;

    using MvcEssentials.Data.Models;
    using MvcEssentials.Data.Common;

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
