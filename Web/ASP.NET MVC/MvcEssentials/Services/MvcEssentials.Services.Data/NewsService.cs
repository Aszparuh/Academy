namespace MvcEssentials.Services.Data
{
    using System.Linq;
    using MvcEssentials.Data.Models;
    using MvcEssentials.Data.Common;
    using System;

    public class NewsService : INewsService
    {
        private readonly IDbRepository<NewsArticle> articles;

        public NewsService(IDbRepository<NewsArticle> articles)
        {
            this.articles = articles;
        }

        public void Add(NewsArticle article)
        {
            this.articles.Add(article);
            this.articles.Save();
        }

        public IQueryable<NewsArticle> GetAllNew()
        {
            return this.articles
                .All()
                .OrderByDescending(a => a.ModifiedOn)
                .ThenByDescending(a => a.CreatedOn);
        }

        public NewsArticle GetById(int id)
        {
            return this.articles.GetById(id);
        }
    }
}
