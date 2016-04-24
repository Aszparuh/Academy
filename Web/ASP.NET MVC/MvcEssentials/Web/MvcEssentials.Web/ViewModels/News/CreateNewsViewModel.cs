namespace MvcEssentials.Web.ViewModels.News
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web.Mvc;

    using Data.Models;
    using Infrastructure.Mapping;

    public class CreateNewsViewModel : IMapTo<NewsArticle>
    {
        public string Title { get; set; }

        public int NewsCategoryId { get; set; }

        [DisplayName("Category")]
        public IEnumerable<SelectListItem> NewsCategories { get; set; }

        public string ApplicationUserId { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public File Image { get; set; }
    }
}