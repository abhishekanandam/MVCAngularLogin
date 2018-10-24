using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnguarLogin.Models;
using System.Data;
namespace AnguarLogin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        database_Access_Layer.db dblayer = new database_Access_Layer.db();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult dashboard()
        {
            return View();
        }

        public JsonResult userlogin(user us)
        {
            string  result = Convert.ToString(dblayer.userlogin(us));

            if (result=="1")
            {
                Session["user"] = us.email;
            }
            else
            {
                result = "Email or Password is wrong";
                
            }
            return Json(result,JsonRequestBehavior.AllowGet);
        }

    }
}
