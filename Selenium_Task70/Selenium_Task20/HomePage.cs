using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Task70
{
    public class HomePage
    {
        By DisplayingUserMenuLocator = By.XPath("//a[@class='home-link usermenu-link__control home-link_black_yes']");
        By LogoutOptionLocator = By.XPath("//a[@aria-label='Выйти']");
        By UserAvatarLocator = By.XPath("//span[@class='avatar__image  avatar__image-server0']");
        By LoginButtonLocator = By.XPath("//a[contains(@class,'desk-notif-card__login-new-item_enter')]");
        By LoginTitleLocator = By.XPath("//div[contains(text(), 'Войти')]");

        public IWebDriver driver;

        public IWebElement UserAvatar() { return driver.FindElement(UserAvatarLocator); }
        public IWebElement UserMenuDisplaying() { return driver.FindElement(DisplayingUserMenuLocator); }
        public IWebElement LoginButton { get; set; }
        public IWebElement LoginTitle() { return driver.FindElement(LoginTitleLocator);}

    public HomePage(IWebDriver _driver)
        {
            driver = _driver;
            LoginButton = driver.FindElement(LoginButtonLocator);
           // LoginTitle = driver.FindElement(LoginTitleLocator);
        }
        public void Logout()
        {
            UserMenuDisplaying().Click();
            driver.FindElement(LogoutOptionLocator).Click();
        }
        public LoginPage GoToLoginPage()
        {
            LoginButton.Click();
            return new LoginPage(driver);
        }
    }
}
