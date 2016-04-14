namespace MvcEssentials.Services.Data
{
    using System.Linq;

    using MvcEssentials.Data.Models;
    using MvcEssentials.Data.Common;

    public class NewsCategoryService : INewsCategoryService
    {
        private readonly IDbRepository<NewsCategory> categories;

        public NewsCategoryService(IDbRepository<NewsCategory> categories)
        {
            this.categories = categories;
        }

        public IQueryable<NewsCategory> GetAll()
        {
            return this.categories.All().OrderBy(c => c.Name);
        }
    }
}
