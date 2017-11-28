using BankingKataMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingKataMVC.Services {
    public class CheckingAccountService {

        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext) {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastName, string userId, decimal balance) {
            var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount {
                FirstName = firstName,
                LastName = lastName,
                AccountNumber = accountNumber,
                Balance = balance,
                ApplicationUserId = userId };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();
        }
    }
}