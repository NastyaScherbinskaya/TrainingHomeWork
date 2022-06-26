using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Task70
{
    public class ManageBrowser
    {
        public IWebDriver driver;

        public IWebDriver BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.yandex.com";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            return driver;
        } 
        public void AfterTest()
        {
            driver.Close();
        }
    }
}
