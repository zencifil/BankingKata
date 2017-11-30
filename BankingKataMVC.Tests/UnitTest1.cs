﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingKataMVC.Controllers;
using System.Web.Mvc;

namespace BankingKataMVC.Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void FooActionReturnsAboutView() {
            var homeController = new HomeController();
            var result = homeController.Foo() as ViewResult;
            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void ContactFormSaysThanks() {
            var homeController = new HomeController();
            var result = homeController.Contact("I love your bank.") as ViewResult;
            Assert.IsNotNull(result.ViewBag.Message);
        }
    }
}
