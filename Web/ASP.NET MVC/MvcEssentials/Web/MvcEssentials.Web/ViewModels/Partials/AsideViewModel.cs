namespace MvcEssentials.Web.ViewModels.Partials
{
    using System.Collections.Generic;

    using Home;

    public class AsideViewModel
    {
        public IEnumerable<NewsArticleViewModel> RecentArticles { get; set; }

        public IEnumerable<NewsArticleViewModel> MostVisitedArticles { get; set; }
    }
}