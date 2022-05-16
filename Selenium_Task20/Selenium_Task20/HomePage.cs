using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Task20
{
    public class HomePage
    {
        By LoginButtonLocator = By.XPath("//a[contains(@class,'desk-notif-card__login-new-item_enter')]");

        public IWebDriver driver;
        public IWebElement LoginButton { get; set; }
        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
            LoginButton = driver.FindElement(LoginButtonLocator);
        }

        public LoginPage GoToLoginPage()
        {
            LoginButton.Click();
            return new LoginPage(driver);
        }
    }
}
