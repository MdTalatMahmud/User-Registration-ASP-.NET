using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Table U)
        {
            if (ModelState.IsValid)
            {
                using (MyDatabaseEntities de=new MyDatabaseEntities())
                {
                    de.Tables.Add(U);
                    de.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "Successfully user created!";
                }
            }

            return View(U);
        }
    }
}