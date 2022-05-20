using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Task50;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginTests
{
    public class Task50Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void BeginTest()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
        
        [Test]
        [TestCase("kostyukevitch-marija", "kostyukevitch_marija")]
        [TestCase("sedova-l1n", "sedova_l1n")]
        public void SuccessfulLogin(string username, string password)
        {
            driver.Url = "https://www.yandex.com";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = homePage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(e=>e.FindElement(By.XPath("//span[@class='username desk-notif-card__user-name']")));

            Assert.IsTrue(driver.FindElement(By.XPath("//span[@class='avatar__image  avatar__image-server0']")).Displayed);
        }

        [Test]
        public void MultiSelect()
        {
            string[] ExpectedResult = { "Florida", "New York", "Texas" };

            driver.Url = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
            var select1 = driver.FindElement(By.XPath("//option[@value='Florida']")).Text;
            var select2 = driver.FindElement(By.XPath("//option[@value='New York']")).Text;
            var select3 = driver.FindElement(By.XPath("//option[@value='Texas']")).Text;

            string[] ActualResult = { select1, select2, select3 };

            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [Test]
        public void ConfirmBoxAlertIsDisplaying()
        {
            driver.Url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";

            IWebElement ConfirmBoxButton = driver.FindElement(By.XPath("//button[@onclick='myConfirmFunction()']"));
            ConfirmBoxButton.Click();

            var alertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();

            Assert.AreEqual("Press a button!", alertText);
        }

        [Test]
        public void ConfirmBoxAlertIsClicked()
        {
            driver.Url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";

            driver.FindElement(By.XPath("//button[@onclick='myConfirmFunction()']")).Click();
            driver.SwitchTo().Alert().Accept();

            var ExpectedResult = driver.FindElement(By.XPath("//p[@id='confirm-demo'][contains(text(),'You pressed OK!')]")).Text;

            Assert.AreEqual("You pressed OK!", ExpectedResult);
        }

        [Test]
        public void JavaScriptAlertBox()
        {
            driver.Url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";

            driver.FindElement(By.XPath("//button[@onclick='myPromptFunction()']")).Click();
            driver.SwitchTo().Alert().SendKeys("Nastya");
            driver.SwitchTo().Alert().Accept();

            var ExpectedResult = driver.FindElement(By.XPath("//p[@id='prompt-demo'][contains(text(),'Nastya')]")).Text;

            Assert.AreEqual("You have entered 'Nastya' !", ExpectedResult);
        }

        [Test]
        public void WaitingWhenUserIsDisplayed()
        {
            driver.Url = "https://demo.seleniumeasy.com/dynamic-data-loading-demo.html";

            driver.FindElement(By.CssSelector("#save")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Assert.IsTrue(wait.Until(e => e.FindElement(By.XPath("//div[contains(text(),'First Name')]"))).Displayed);
        }

        [Test]
        public void RefreshingPageWhenPercentageMore50()
        {
            driver.Url = "https://demo.seleniumeasy.com/bootstrap-download-progress-demo.html";

            driver.FindElement(By.CssSelector("#cricle-btn")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(e => e.FindElement(By.XPath("//input[@id='cricleinput'][@value>='50']")));

            driver.Navigate().Refresh();
        }

        [Test]
        public void ReturnListOfCustomObjects()
        {
            Task9 list = new Task9(driver);

            driver.Url = "https://demo.seleniumeasy.com/table-sort-search-demo.html";

            driver.FindElement(By.XPath("//option[@value='10']")).Click();

            list.GetListEmployeesFromAllPages();
            list.DisplayElementWithConditions(); 
        }
    }
}