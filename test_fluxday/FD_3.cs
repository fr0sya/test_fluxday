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
using OpenQA.Selenium.Support.UI;



namespace test_fluxday
{
    [TestFixture]
    class FD_3
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new FirefoxDriver();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://app.fluxday.io/users/sign_in");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("user_email")).Click();
            driver.FindElement(By.Id("user_email")).Clear();
            driver.FindElement(By.Id("user_email")).SendKeys("admin@fluxday.io");

            //
            driver.FindElement(By.Id("user_password")).Click();
            driver.FindElement(By.Id("user_password")).Clear();
            driver.FindElement(By.Id("user_password")).SendKeys("password");
            //
            driver.FindElement(By.ClassName("btn-login")).Submit();
            //Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }

        [Test]
        public void Test_FD()
        {
            driver.FindElement(By.CssSelector("body > div.fixed > nav > section > ul.right > li > a")).Click();
            Thread.Sleep(2000);

            // fills in the task title
            driver.FindElement(By.Id("task_name")).Click();
            driver.FindElement(By.Id("task_name")).Clear();
            driver.FindElement(By.Id("task_name")).SendKeys("Task_1");

            // fills in the description
            driver.FindElement(By.Id("task_description")).Click();
            driver.FindElement(By.Id("task_description")).Clear();
            driver.FindElement(By.Id("task_description")).SendKeys("New task");

            //Thread.Sleep(2000);
            // select team
            //driver.FindElement(By.ClassName("select2-chosen")).Clear();
            driver.FindElement(By.CssSelector("#s2id_task_team_id")).Click();
            driver.FindElement(By.CssSelector("#select2-drop > div > input")).SendKeys("Uzity Development");
            driver.FindElement(By.CssSelector("body > div.select2-drop.select2-display-none.select2-with-searchbox.select2-drop-active > ul")).Click();

            // task_start_date 
            //              !!! didn't work correctly !!!
            driver.FindElement(By.Id("task_start_date")).Click();
            driver.FindElement(By.Id("task_start_date")).Clear();
            driver.FindElement(By.Id("task_start_date")).SendKeys("2016/07/01 16:33");
            Thread.Sleep(5000);


            //   task_end_date
          //  driver.FindElement(By.Id("task_end_date")).Click();
         //   driver.FindElement(By.Id("task_end_date")).Clear();
           // driver.FindElement(By.Id("task_end_date")).SendKeys(Keys.Delete);
           // driver.FindElement(By.Id("task_end_date")).SendKeys("2018/11/05 16:33");
         //   Thread.Sleep(5000);





            // IWebElement element = driver.FindElement(By.ClassName("select2-chosen"));
            // SelectElement dropdown = new SelectElement(element);
            //dropdown.SelectByText("Uzity Development");
            // Thread.Sleep(2000);


            // SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("select2-drop")));
            //oSelect.SelectByText("Uzity Development");
            //Thread.Sleep(2000);

            //driver.FindElement(By.ClassName("select2-chosen")).Selected(Uzity Development);


        }
    }
}
