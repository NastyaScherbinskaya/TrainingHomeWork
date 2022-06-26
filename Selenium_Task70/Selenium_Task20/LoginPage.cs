﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Selenium_Task70
{
    public class LoginPage : BasePage 
    {
        By UsernameFieldLocator = By.XPath("//input[@type='text']");
        By LoginButtonLocator = By.XPath("//button[@id='passp:sign-in']");
        By passwordFieldLocator = By.XPath("//input[@type='password']");

        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void GoToCabinet(string username, string password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(UsernameFieldLocator).SendKeys(username);
            driver.FindElement(LoginButtonLocator).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(passwordFieldLocator));
            wait.Until(ExpectedConditions.ElementToBeClickable(passwordFieldLocator));

            driver.FindElement(passwordFieldLocator).SendKeys(password);
            driver.FindElement(LoginButtonLocator).Click();
        }
    }
}