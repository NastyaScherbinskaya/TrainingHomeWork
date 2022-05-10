using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Task20;
using System.Threading;

namespace TestProject1
{
    [TestClass]
    public class LoginTests
    {
        public IWebDriver driver;

        [TestInitialize]
        public void BeginTest()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.yandex.com";
        }

        [TestCleanup]
        public void EndTest()
        {
            driver.Close();
        }

        [TestMethod]
        public void SuccessfulLogin()
        {
            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = homePage.GoToLoginPage();

            var username = "kostyukevitch-marija";
            var password = "kostyukevitch_marija";

            loginPage.GoToCabinet(username, password);

            Assert.IsTrue(driver.FindElement(By.XPath("//span[@class='avatar__image  avatar__image-server0']")).Displayed);
        }
    }

    //Class for Task2
    public class Variables
    {
        //Password field on Login page 
        By Xpath = By.XPath("//input[@type='password']");
        By id = By.Id("passp-field-passwd");
        By name = By.ClassName("Textinput-Control");
        By nane = By.Name("passwd");
        By css = By.CssSelector("#passp-field-passwd");

        //avatar image on Login page 
        By tag = By.TagName("a");

        //Learn more link on Login page 
        By linkFull = By.LinkText("Learn more");
        By linkPart = By.PartialLinkText("Learn");
    }
}

