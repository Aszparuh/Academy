namespace MvcEssentials.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Data.Models;
    using Services.Data;
    using ViewModels.Home;
    using ViewModels.News;

    public class NewsController : BaseController
    {
        private readonly INewsService newsArticles;
        private readonly INewsCategoryService newsCategories;

        public NewsController(INewsService newsArticles, INewsCategoryService newsCategories)
        {
            this.newsArticles = newsArticles;
            this.newsCategories = newsCategories;
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
            var list = this.newsCategories.GetAll().Select(c => new SelectListItem() { Text = c.Name, Value = c.Id.ToString() }).ToList();
            model.NewsCategories = list;
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
                this.newsArticles.Add(modelToSave);

                return this.RedirectToAction("Index", "Home");
            }

            return this.View(input);
        }
    }
}