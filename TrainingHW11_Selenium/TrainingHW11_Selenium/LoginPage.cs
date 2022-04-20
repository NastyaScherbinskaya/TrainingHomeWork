using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrainingHW11_Selenium
{
    public class LoginPage
    {
        string MailLocator = "//input[@placeholder='Ник или e-mail']";
        string PasswordLocator = "//input[@type='password']";
        string SubmitLocator = "//button[contains(text(),'Войти')]";

        public IWebDriver driver;
        public IWebElement mail { get; set; }
        public IWebElement password { get; set; }
        public IWebElement submit { get; set; }
        public IWebElement UserLogo { get; set; }
        
        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;
            mail = driver.FindElement(By.XPath(MailLocator));
            password = driver.FindElement(By.XPath(PasswordLocator));
            submit = driver.FindElement(By.XPath(SubmitLocator));
        }

        public void GoToCabinet(string _mail, string _password)
        {
            mail.SendKeys(_mail);
            password.SendKeys(_password);
            submit.Click();
        }
    }
}
