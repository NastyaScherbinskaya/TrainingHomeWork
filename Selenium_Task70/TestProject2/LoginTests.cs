using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Task20;
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
            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = homePage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);

            Assert.IsTrue(driver.FindElement(By.XPath("//span[@class='avatar__image  avatar__image-server0']")).Displayed);
        }

        [Test]
        [TestCase("kostyukevitch-marija", "kostyukevitch_marija")]
        public void LogOut(string username, string password)
        {
            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = homePage.GoToLoginPage();

            loginPage.GoToCabinet(username, password);
            loginPage.Logout();
            Assert.IsTrue(driver.FindElement(By.XPath("//div[contains(text(), 'Войти')]")).Displayed);
        }
    }
}