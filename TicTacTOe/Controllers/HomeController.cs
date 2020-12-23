using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacTOe.Models;
using TicTacTOe.Models.App;


using System.Web.Security;

namespace TicTacTOe.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
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


        public ActionResult Users()
        {
            return View(db.Users.ToList());
        }

        [HttpPost]
        public JsonResult SendRequest(Game Game)
        {
            Console.WriteLine(Game);
            //ApplicationUser User = db.Users.Find(opponentId);
            //Game Game = new Game();
            //Game.Player = db.Users.Find(userId);
            //Game.Opponent = User;
            return Json(Game, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public JsonResult Move(Game Game)
        {
            bool character = false;
            int x_cor = 1;
            
            return Json(Game, JsonRequestBehavior.AllowGet);


        }
    }
}