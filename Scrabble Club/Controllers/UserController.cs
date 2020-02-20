using Scrabble_Club.Models;
using System.Web.Mvc;

namespace Scrabble_Club.Controllers
{
    public class UserController : Controller
    {
        Model model = new Model();
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            model.AddUser(user);
            return RedirectToAction("User", "Home", new { name = user.firstName + " " + user.lastName });
        }

        public ActionResult Edit()
        {
            return View();
        }

        public JsonResult Get(string name)
        {
            User user = model.GetUser(name);
            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}
