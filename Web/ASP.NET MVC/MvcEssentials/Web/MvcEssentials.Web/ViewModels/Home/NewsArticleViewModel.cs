namespace MvcEssentials.Web.ViewModels.Home
{
    using System.Web.Mvc;

    using Infrastructure.Mapping;
    using MvcEssentials.Data.Models;

    public class NewsArticleViewModel : IMapFrom<NewsArticle>, IMapTo<NewsArticle>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }
    }
}