using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Task70;
using System.Threading;

namespace LoginTests
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void BeginTest()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.yandex.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

        [Test]
        [TestCase("kostyukevitch-marija", "kostyukevitch_marija")]
        public void SuccessfulLogin(string username, string password)
        {
            HomePage homepage = new HomePage(driver);
            LoginPage loginPage = homepage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);
        }

        [Test]
        [TestCase("kostyukevitch-marija", "kostyukevitch_marija")]
        public void LogOut(string username, string password)
        {
            HomePage homepage = new HomePage(driver);
            LoginPage loginPage = homepage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);

            homepage.Logout();
            Assert.IsTrue(homepage.LoginTitle().Displayed);
        }
    }
}