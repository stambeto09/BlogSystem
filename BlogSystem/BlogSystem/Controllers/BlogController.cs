namespace BlogSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    public class BlogController : BaseController
    {
        // GET: /BlogController/
        [ValidateInput(false)]
        public ActionResult Index(int year, int month, int day, string article, int id)
        {
            DateTime articleDate = new DateTime(year, month, day);
            List<Article> articles = db.Articles.ToList();
            string parsedArticleName = ParseArticleName(article);

            Article newArticle = articles.Find(art => art.ArticleID == id && 
                art.ArticleName == parsedArticleName &&
                art.DatePublished.Date.Date == articleDate.Date.Date);
            
            return View(newArticle);
        }

        [ValidateInput(false)]
        public ActionResult SearchByName(string name)
        {
            var articles = db.Articles.ToList();
            string parsedArticleName = ParseArticleName(name).ToLower();
            Article article = articles.Find(art => art.ArticleName.ToLower()
                .Contains(parsedArticleName));

            return View("Index", article);
        }

        [NonAction]
        private string ParseArticleName(string name)
        {
            return name.Replace('-', ' ');
        }
	}
}