namespace BlogSystem.Controllers
{
    using BlogSystem.Models;
    using System.Web.Mvc;
    using System.Web.Security;

    public abstract class BaseController : Controller
    {
        protected User currentUser { get; set; }

        protected ApplicationDbContext db = new ApplicationDbContext();

        [NonAction]
        public void SystemSettings()
        {

        }
    }
}