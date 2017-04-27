using System.Data.Entity;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            //using (var database = new DbContext())
            //{
            //    var articles = database.Articles.Include(a => a.Author).ToList();
            //}

            return View();
        }
    }
}