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
        ManageBrowser ManageBrowser = new ManageBrowser();
        public IWebDriver driver;

        [Test]
        [TestCase("kostyukevitch-marija", "kostyukevitch_marija")]
        public void SuccessfulLogin(string username, string password)
        {
            driver = ManageBrowser.BeginTest();
            HomePage homepage = new HomePage(driver);
            LoginPage loginPage = homepage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);

            ManageBrowser.EndTest();
        }

        [Test]
        [TestCase("kostyukevitch-marija", "kostyukevitch_marija")]
        public void LogOut(string username, string password)
        {
            driver = ManageBrowser.BeginTest();
            HomePage homepage = new HomePage(driver);
            LoginPage loginPage = homepage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);

            homepage.Logout();
            Assert.IsTrue(homepage.LoginTitle().Displayed);

            ManageBrowser.EndTest();
        }
    }
}