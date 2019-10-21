using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProjectBankingHcl.Models;

namespace MvcProjectBankingHcl.Controllers
{
    public class AccountsDetailsController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public AccountsDetailsController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           if(disposing)
            {
                dbContext.Dispose();
            }
        }

        // GET: AccountsDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountsDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
       // [Route("AccountsDetails/CreateANewAccount/{AccountHolderDetailsId}")]
        // GET: AccountsDetails/Create
        public ActionResult CreateANewAccount()
        {
            //AccountDetails accountDetails = new AccountDetails();
            //return View(accountDetails);
           // var account = dbContext.accountdetails.Include(a => a.accountholderdetails).ToList();
            return View(account);
        }

        // POST: AccountsDetails/Create
        [HttpPost]
        public ActionResult CreateANewAccount(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountsDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountsDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountsDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountsDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
