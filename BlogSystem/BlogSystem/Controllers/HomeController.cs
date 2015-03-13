namespace BlogSystem.Controllers
{
    using PagedList;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        private const int PostPerPage = 1;


        [ValidateInput(false)]
        public ActionResult Index(int page = 1)
        {
            List<Article> articles = db.Articles.ToList();
            PagedList<Article> pagedList = new PagedList<Article>(articles, page, 1);
            return View(pagedList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}