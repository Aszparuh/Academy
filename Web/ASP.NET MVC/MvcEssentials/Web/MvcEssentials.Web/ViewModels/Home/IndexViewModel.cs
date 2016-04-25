namespace MvcEssentials.Web.ViewModels.Home
{
    using System.Collections.Generic;
    using Partials;

    public class IndexViewModel
    {
        public IEnumerable<NewsArticleViewModel> Articles { get; set; }

        public IEnumerable<NewsCategoryViewModel> Categories { get; set; }

        public IEnumerable<RegionViewModel> Regions { get; set; }

        public AsideViewModel Aside { get; set; }
    }
}