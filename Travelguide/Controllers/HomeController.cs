using System.Web.Mvc;
using Travelguide.Models;
using Travelguide.DAL;
using System.Web.Helpers;
using System.Linq;


namespace Travelguide.Controllers
{
    public class HomeController : Controller
    {
        private readonly TravelGuideContext db = new TravelGuideContext();
        public ActionResult Index()
        {
            return View();
        }



        //User entry into the webpage
        public ActionResult Login(Users user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                Session["LoginError"] = "E-poçt və ya şifrə boş ola bilməz";
                return RedirectToAction("index");
            }

            Users lgn = db.User.FirstOrDefault(u => u.Email == user.Email);

            if (lgn != null)
            {
                if (Crypto.VerifyHashedPassword(lgn.Password, user.Password))
                {
                    Session["Login"] = true;
                    Session["User"] = lgn;
                    return RedirectToAction("index", "home");
                }
            }

            Session["LoginError"] = "E-poçt və ya şifrə yalnışdır";
            return RedirectToAction("index");
        }
    }
}