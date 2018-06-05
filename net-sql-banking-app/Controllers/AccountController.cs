using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net_sql_banking_app.Models;

namespace net_sql_banking_app.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Random()
        {
            var acc = new Account() { Name = "Chequing" };

            return View(acc);
        }
    }
}