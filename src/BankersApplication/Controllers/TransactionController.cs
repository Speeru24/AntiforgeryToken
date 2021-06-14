using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankersApplication.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Index()
        {
            return View("TransferAmt");
        }


        [ValidateAntiForgeryToken()]
        public ActionResult TransferAmt()
        {
            // Money transfer logic goes here  
            return Content(Request.Form["amount"] + " has been transferred to account " + Request.Form["account"]);
        }
    }
}