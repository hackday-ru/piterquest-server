using System.Web.Mvc;
using Quests.Models;
using System.Security.Cryptography;
using System.Text;

namespace Quests.Controllers
{
  public class HomeController : Controller
  {
    private QuestDBEntities1 context;

    public HomeController()
    {
      context = new QuestDBEntities1();
    }

    public ActionResult createQuestPage()
    {
      return View();
    }

    // GET: Home
    public ActionResult Index()
    {
      ViewBag.quests = context.Quests;
      return View();
    }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public ActionResult Login(string login, string password)
        {
            var result = false;
            using (MD5 md5Hash = MD5.Create())
            {
                if (login == "admin" && GetMd5Hash(md5Hash, password) == "912e79cd13c64069d91da65d62fbb78c")
                {
                    result = true;
                }
            }

                
            
            return Json(result, JsonRequestBehavior.AllowGet);
        }
  }
}
