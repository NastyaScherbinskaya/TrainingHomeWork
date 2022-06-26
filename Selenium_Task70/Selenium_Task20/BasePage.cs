using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Sentry.Protocol;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Task70
{
    public class BasePage
    {
        public IWebDriver driver;

        public Type PageName()
        {
            return GetType();
        }

        public void Navigate(Uri url)
        {
            Contract.Requires(url != null);

            driver.Navigate().GoToUrl(url);
        }

        public void SwitchToFrame(IWebElement inlineFrame)
        {
            driver.SwitchTo().Frame(inlineFrame);
        }
        public Screenshot GetScreenshot()
        {
            return ((ITakesScreenshot)driver).GetScreenshot();
        }

        public void SaveScreenshot()
        {
            var FullPath = Directory.GetCurrentDirectory();
            var Path = FullPath.Substring(0, FullPath.LastIndexOf("Selenium_Task70")) + "Selenium_Task70\\Screenshot\\";
            GetScreenshot().SaveAsFile(Path + "screenshot" + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".jpg", ScreenshotImageFormat.Jpeg);
        }
        public void NavigateBack()
        {
            driver.Navigate().Back();
        }

        public void Refresh()
        {
            driver.Navigate().Refresh();
        }

        public void AlertAccept()
        {
            driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().DefaultContent();
        }

        public void ExplicitWaiter()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void WaitPageLoading()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }
    }
}

