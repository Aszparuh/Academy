namespace MvcEssentials.Web.ViewModels.News
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Data.Models;
    using Infrastructure.Mapping;

    public class CreateNewsViewModel : IMapTo<NewsArticle>
    {
        public string Title { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public File Image { get; set; }
    }
}