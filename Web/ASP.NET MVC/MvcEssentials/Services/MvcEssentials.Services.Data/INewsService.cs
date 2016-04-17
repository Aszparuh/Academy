namespace MvcEssentials.Services.Data
{
    using System.Linq;
    using MvcEssentials.Data.Models;

    public interface INewsService
    {
        IQueryable<NewsArticle> GetAllNew();

        NewsArticle GetById(int id);
    }
}
