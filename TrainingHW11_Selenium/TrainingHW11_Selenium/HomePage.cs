using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrainingHW11_Selenium
{
    public class HomePage
    {
        string LoginButtonLocator = "//div[text()='Вход']";
        string CatalogTabLocator = "//a[contains(text(),'Каталог')]";

        public IWebDriver driver;
        public IWebElement LoginButton { get; set; }
        public IWebElement CatalogTab {get;set;}

        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
            LoginButton = driver.FindElement(By.XPath(LoginButtonLocator));
            CatalogTab = driver.FindElement(By.XPath(CatalogTabLocator));
        }

        public LoginPage GoToLoginPage()
        {
            LoginButton.Click();
            return new LoginPage(driver);
        }

        public CatalogPage GoToCatalogtab()
        {
            CatalogTab.Click();
            return new CatalogPage(driver);
        }
    }
}
