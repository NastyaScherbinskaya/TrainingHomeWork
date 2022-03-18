using System;

namespace TrainingHW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();

            office.Employees.Add(new BAEmployee("Maria", "Golubeva", "BA"));
            office.Employees.Add(new DevEmployee("Dmitry", "Nadtochy", "DEV"));
            office.Employees.Add(new QAEmployee("Nastya", "Scherbinskaya", "DEV"));
            office.Employees.Add(new QAEmployee("Olya", "Scherbinskaya", "QA"));
            office.Employees.Add(new PMEmployee("Natalia", "Lukyaniuk", "PM"));
            office.Employees.Add(new QAAutomationEmployee("Kirill", "Vasilenko", "QA Team Lead"));
            office.Employees.Add(new QAAutomationTeamLead("Pavel", "Ezepa", "QA Automation Team Lead"));
            office.Employees.Add(new DevTeamLead("Maxim", "Torop", "DEV Team lead"));
            office.Employees.Add(new QATeamLead("Viktoria", "Yaroshenko", "QA Team Lead"));

            foreach (Employee employee in office.Employees)
            {
                if (employee is IAssignTask || employee is ICodeReview || employee is ICodeWrite)
                {
                    Console.WriteLine($"Info: First Name - {employee.FirstName}, Last Name - {employee.LastName}, Position - {employee.Position}");
                }
            }
        }
    }
}
