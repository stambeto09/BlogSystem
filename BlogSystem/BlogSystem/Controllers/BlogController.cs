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
            string parsedArticleName = article.Replace('-', ' ');

            Article newArticle = articles.Find(art => art.ArticleID == id && 
                art.ArticleName == parsedArticleName &&
                art.DatePublished.Date.Date == articleDate.Date.Date);
            
            return View(newArticle);
        }
	}
}