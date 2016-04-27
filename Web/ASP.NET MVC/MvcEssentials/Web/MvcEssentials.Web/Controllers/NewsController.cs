namespace MvcEssentials.Web.Controllers
{
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Services.Data;
    using ViewModels.Home;
    using ViewModels.News;

    public class NewsController : BaseController
    {
        private readonly INewsService newsArticles;
        private readonly INewsCategoryService newsCategories;
        private readonly IRegionsService newsRegions;

        public NewsController(INewsService newsArticles, INewsCategoryService newsCategories, IRegionsService newsRegions)
        {
            this.newsArticles = newsArticles;
            this.newsCategories = newsCategories;
            this.newsRegions = newsRegions;
        }

        // GET: News
        public ActionResult Details(int id, string name)
        {
            var article = this.newsArticles.GetById(id);

            if (article != null && article.Title == name)
            {
                var viewModel = this.Mapper.Map<NewsArticleViewModel>(article);
                return this.View(viewModel);
            }
            else
            {
                return new HttpNotFoundResult("Article not found");
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Journalist")]
        public ActionResult Create()
        {
            var model = new CreateNewsViewModel();
            var categoriesList = this.newsCategories.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            var regionsList = this.newsRegions.GetAll().Select(r => new SelectListItem() { Text = r.Name, Value = r.Id.ToString() }).ToList();

            model.NewsCategories = categoriesList;
            model.Regions = regionsList;
            return this.View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Journalist")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateNewsViewModel input)
        {
            if (this.ModelState.IsValid)
            {
                var modelToSave = this.Mapper.Map<NewsArticle>(input);
                modelToSave.ApplicationUserId = this.User.Identity.GetUserId();
                this.newsArticles.Add(modelToSave);

                return this.RedirectToAction("Index", "Home");
            }

            return this.View(input);
        }
    }
}