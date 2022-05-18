using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium_Task20
{
    public class LoginPage
    {
        By UsernameFieldLocator = By.XPath("//input[@type='text']");
        By LoginButtonLocator = By.XPath("//button[@id='passp:sign-in']");
        By passwordFieldLocator = By.XPath("//input[@type='password']");

        public IWebDriver driver;

        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void GoToCabinet(string username, string password)
        {
            driver.FindElement(UsernameFieldLocator).SendKeys(username);
            driver.FindElement(LoginButtonLocator).Click();
            Thread.Sleep(5000);
            driver.FindElement(passwordFieldLocator).SendKeys(password);
            driver.FindElement(LoginButtonLocator).Click();
            Thread.Sleep(5000);
        }
        public void Logout()
        {
            driver.FindElement(By.XPath("//a[@class='home-link usermenu-link__control home-link_black_yes']")).Click();
            driver.FindElement(By.XPath("//a[@aria-label='Выйти']")).Click();
        }
    }
}
