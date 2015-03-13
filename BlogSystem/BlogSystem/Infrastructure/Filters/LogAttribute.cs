namespace BlogSystem.Infrastructure
{
    using System.Web.Mvc;

    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //var db = this.Data.Logs.Add(new Log { Message = filterContext.HttpContext.Request.RawUrl)};
            //db.SaveChanges();

            base.OnActionExecuted(filterContext);
        }
    }
}