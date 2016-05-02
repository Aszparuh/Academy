namespace MvcEssentials.Web.ViewModels.Partials
{
    using System.Collections.Generic;

    using Home;

    public class AsideViewModel
    {
        public IEnumerable<NewsArticleIndexViewModel> RecentArticles { get; set; }

        public IEnumerable<NewsArticleIndexViewModel> MostVisitedArticles { get; set; }
    }
}