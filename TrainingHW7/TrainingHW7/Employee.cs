using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public Employee(string fName, string lName, string posit)
          {
              FirstName = fName;
              LastName = lName;
              Position = posit;
          }
    }
}
