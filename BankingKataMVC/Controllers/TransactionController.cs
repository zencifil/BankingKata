﻿using BankingKataMVC.Models;
using BankingKataMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingKataMVC.Controllers {

    [Authorize]
    public class TransactionController : Controller {
        private IApplicationDbContext db;

        public TransactionController() {
            db = new ApplicationDbContext();
        }

        public TransactionController(IApplicationDbContext dbContext) {
            db = dbContext;
        }

        // GET: Transaction
        public ActionResult Deposit(int checkingAccountId) {

            return View();
        }

        [HttpPost]
        public ActionResult Deposit(Transaction transaction) {
            if (ModelState.IsValid) {
                db.Transactions.Add(transaction);
                db.SaveChanges();
                var service = new CheckingAccountService(db);
                service.UpdateBalance(transaction.CheckingAccountId);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
