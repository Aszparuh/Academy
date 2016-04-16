namespace MvcEssentials.Web.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;

    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly INewsService newsArticles;
        private readonly INewsCategoryService newsCategories;
        private readonly IRegionsService regions;

        public HomeController(INewsService newsArticles, INewsCategoryService newsCategories, IRegionsService regions)
        {
            this.newsArticles = newsArticles;
            this.newsCategories = newsCategories;
            this.regions = regions;
        }

        public ActionResult Index()
        {
            var news = this.newsArticles.GetAllNew().To<NewsArticleViewModel>().ToList();
            var categories = this.newsCategories.GetAll().To<NewsCategoryViewModel>().ToList();
            var regions = this.regions.GetAll().To<RegionViewModel>().ToList();

            var viewModel = new IndexViewModel()
            {
                Articles = news,
                Categories = categories,
                Regions = regions
            };

            return this.View(viewModel);
        }

        public ActionResult News(int id, string name)
        {
            var article = this.newsArticles.GetAllNew().Where(a => a.Id == id).To<NewsArticleViewModel>().FirstOrDefault();

            if (article != null && article.Title == name)
            {
                return this.View(article);
            }
            else
            {
                return new HttpNotFoundResult("Article not found");
            }
        }

        public ActionResult About()
        {
            this.ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            this.ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}