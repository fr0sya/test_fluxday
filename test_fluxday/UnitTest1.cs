using System;
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
    class SeleniumFirst
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
            driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul > li:nth-child(5) > a")).Click();
            Thread.Sleep(2000);


            //Assert.AreEqual("ABOUT",
            //driver.FindElement(By.CssSelector("#about h2")).Text);

            //driver.FindElement(By.ClassName("btn btn-lg btn-outline")).Submit();
            // driver.FindElement(By.CssSelector("#help > div > div:nth-child(2) > div > div.text-center.spacer > a")).Submit();
            driver.FindElement(By.XPath("//*[@id='help']/div/div[2]/div/div[3]/a")).Click();
            //driver.FindElement(By.ClassName("btn btn-lg btn-outline")).Submit();
            Thread.Sleep(2000);




            // Assert.AreEqual("OPENSOURCE TASK & PRODUCTIVITY MANAGEMENT TOOL FOR STARTUPS\r\nFluxday was developed by Foradian starting in 2014 and was a critical part of Foradian’s hyper growth and success. Fluxday is engineered based on the concepts of OKR - Objectives and Key Results.\r\n\r\nDownload now",
            // driver.FindElement(By.ClassName("col-lg-12")).Text);



        }
        
    }
}
