using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Task50
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Age { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string pos, string office, int age, string date, int salary) 
        {
            Name = name;
            Position = pos;
            Office = office;
            Age = age;
            StartDate = date;
            Salary = salary;
        }
    }
}
