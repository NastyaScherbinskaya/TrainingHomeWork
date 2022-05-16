using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TrainingHW11_Selenium;
using System.Linq;
using System.Threading;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void BeforeTest()
        {
            driver = new ChromeDriver();

            driver.Url = "https://www.onliner.by";
        }
        [TestCleanup]
        public void Aftertest()
        {
            driver.Close();
        }

        [TestMethod]
        public void LoginSuccessful()
        {
            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = homePage.GoToLoginPage();

            var mail = "rky86275@jiooq.com";
            var password = "nastya_test";

            loginPage.GoToCabinet(mail, password);
            Thread.Sleep(10000);

            Assert.IsNotNull(driver.FindElement(By.XPath("//div[@class='b-top-profile__image js-header-user-avatar']")).Displayed);
        }

        [TestMethod]
        public void GoToCatalogPage()
        {
            HomePage homePage = new HomePage(driver);
            CatalogPage catalogPage = homePage.GoToCatalogtab();

            var title = catalogPage.GetCatalogTitle();

            Assert.AreEqual("КаталогВсе суперцены!", title);
        }
    }
}
