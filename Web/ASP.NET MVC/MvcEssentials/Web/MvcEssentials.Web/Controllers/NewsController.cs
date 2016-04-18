namespace MvcEssentials.Web.Controllers
{
    using System.Web.Mvc;

    using Services.Data;
    using ViewModels.Home;

    public class NewsController : BaseController
    {
        private readonly INewsService newsArticles;

        public NewsController(INewsService newsArticles)
        {
            this.newsArticles = newsArticles;
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
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(NewsArticleViewModel model)
        {
            return this.RedirectToAction("Index", "Home");
        }
    }
}