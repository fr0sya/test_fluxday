﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace test_2018
{
    [TestFixture]
    class FD_2
    {

        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://fluxday.io/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }


        [Test]
        public void TheFluxday1Test()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Thread.Sleep(2000);

            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(5) > a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#help > div > div:nth-child(2) > div > div.text-center.spacer > a")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            //
            driver.FindElement(By.Id("user_email")).Click();
            driver.FindElement(By.Id("user_email")).Clear();
            driver.FindElement(By.Id("user_email")).SendKeys("admin@fluxday.io");

            //
            driver.FindElement(By.Id("user_password")).Click();
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys("password");

            //
            driver.FindElement(By.ClassName("btn-login")).Submit();
            Thread.Sleep(2000);


            Assert.AreEqual("+Task",
                driver.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Text);
            
            // Assert.AreEqual("OPENSOURCE TASK & PRODUCTIVITY MANAGEMENT TOOL FOR STARTUPS\r\nFluxday was developed by Foradian starting in 2014 and was a critical part of Foradian’s hyper growth and success. Fluxday is engineered based on the concepts of OKR - Objectives and Key Results.\r\n\r\nDownload now",
            // driver.FindElement(By.ClassName("col-lg-12")).Text);



        }

    }
}
