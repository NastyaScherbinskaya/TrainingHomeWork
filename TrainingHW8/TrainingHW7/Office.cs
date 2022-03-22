using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW8
{
    class Office
    {
            public List<Employee> Employees { get; }
            public Office()
            {
                Employees = new List<Employee>();
            }
        public void Info(List<Employee> Employees)
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Info: First Name - {employee.FirstName}, Last Name - {employee.LastName}, Position - {employee.Position}, TaxId - {employee.TaxId} ");
            }
        }
    }
    
}
