using System.Web.Mvc;
using Quests.Models;

namespace Quests.Controllers
{
  public class HomeController : Controller
  {
    private QuestDBEntities1 context;

    public HomeController()
    {
      context = new QuestDBEntities1();
    }

    // GET: Home
    public ActionResult Index()
    {
      ViewBag.quests = context.Quests;
      return View();
    }
  }
}
