using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Task50
{
    public class Office
    {
        public List<Employee> employees { get; }
        public IWebDriver driver;

        public Office(IWebDriver _driver)
        {
            driver = _driver;
            employees = new List<Employee>();
        }
        public void DisplayElementWithConditions()
        {
            var AgeValue = 50;
            var SalaryValue = 100000;

            var result = employees.Where(x => x.Age > AgeValue && x.Salary <= SalaryValue).ToArray();

            foreach (var item in result)
            {
                Console.WriteLine($"Name - {item.Name}, Position - {item.Position}, Office - {item.Office}");
            }
        }
        public void GetListEmployeesFromAllPages()
        {
            var CountElementShouldBeDisplayed = driver.FindElement(By.XPath("//option[@value='10']")).Text;
            var CountElementShouldBeDisplayedInt = Convert.ToInt32(CountElementShouldBeDisplayed);

            int CountDisplayedElements = driver.FindElements(By.XPath("//tr[@class='odd']|//tr[@class='even']")).Count;
            var value = true;

            do
            {
                if (CountDisplayedElements == CountElementShouldBeDisplayedInt)
                {
                    for (var i = 1; i <= CountDisplayedElements; i++)
                    {
                        var NewName = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[1]|//tr[" + i + "][@class='even']/td[1]")).Text;
                        var NewPosition = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[2]|//tr[" + i + "][@class='even']/td[2]")).Text;
                        var NewOffice = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[3]|//tr[" + i + "][@class='even']/td[3]")).Text;
                        var NewAge = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[4]|//tr[" + i + "][@class='even']/td[4]")).Text;
                        var NewStartDate = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[5]|//tr[" + i + "][@class='even']/td[5]")).Text;
                        var NewSalary = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[6]|//tr[" + i + "][@class='even']/td[6]")).Text;

                        employees.Add(new Employee(NewName, NewPosition, NewOffice, Convert.ToInt32(NewAge), NewStartDate, int.Parse(Regex.Replace(NewSalary, @"[$,y/]", ""))));
                    }

                    driver.FindElement(By.XPath("//a[@class='paginate_button next']")).Click();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    CountDisplayedElements = driver.FindElements(By.XPath("//tr[@class='odd']|//tr[@class='even']")).Count;
                }
                else if (CountDisplayedElements < CountElementShouldBeDisplayedInt && CountDisplayedElements > 0)
                {
                    for (var i = 1; i <= CountDisplayedElements; i++)
                    {
                        var NewName = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[1]|//tr[" + i + "][@class='even']/td[1]")).Text;
                        var NewPosition = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[2]|//tr[" + i + "][@class='even']/td[2]")).Text;
                        var NewOffice = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[3]|//tr[" + i + "][@class='even']/td[3]")).Text;
                        var NewAge = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[4]|//tr[" + i + "][@class='even']/td[4]")).Text;
                        var NewStartDate = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[5]|//tr[" + i + "][@class='even']/td[5]")).Text;
                        var NewSalary = driver.FindElement(By.XPath("//tr[" + i + "][@class='odd']/td[6]|//tr[" + i + "][@class='even']/td[6]")).Text;

                        employees.Add(new Employee(NewName, NewPosition, NewOffice, Convert.ToInt32(NewAge), NewStartDate, int.Parse(Regex.Replace(NewSalary, @"[$,y/]", ""))));
                    }
                    value = false;
                }
                else if (CountDisplayedElements == 0)
                {
                    Console.WriteLine("There are no elements on the page");
                    value = false;
                }
            }
            while (value is true);
        }
    }
}

