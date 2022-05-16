using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TrainingHW11_Selenium
{
    public class CatalogPage
    {
        string CatalogTitleLocator = "//div[@class='catalog-navigation__title']";

        public IWebDriver driver;
        public IWebElement CatalogTitle { get; set; }

        public CatalogPage(IWebDriver _driver)
        {
            driver = _driver;
            CatalogTitle = driver.FindElement(By.XPath(CatalogTitleLocator));
        }

        public string GetCatalogTitle()
        {
            return CatalogTitle.Text.ToString();
        }
    }
}
