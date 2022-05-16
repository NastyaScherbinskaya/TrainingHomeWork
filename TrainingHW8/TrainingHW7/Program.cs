using System;
using TrainingHW7.Comparer;

namespace TrainingHW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();

            office.Employees.Add(new BAEmployee("Maria", "Golubeva", "BA", 45678));
            office.Employees.Add(new DevEmployee("Dmitry", "Nadtochy", "DEV", 95674));
            office.Employees.Add(new QAEmployee("Nastya", "Scherbinskaya", "DEV", 57860));
            office.Employees.Add(new QAEmployee("Olya", "Scherbinskaya", "QA", 34567));
            office.Employees.Add(new PMEmployee("Natalia", "Lukyaniuk", "PM", 67345));
            office.Employees.Add(new QAAutomationEmployee("Kirill", "Vasilenko", "QA Automation", 34567));
            office.Employees.Add(new QAAutomationTeamLead("Pavel", "Ezepa", "QA Automation Team Lead", 12347));
            office.Employees.Add(new DevTeamLead("Maxim", "Torop", "DEV Team lead", 23960));
            office.Employees.Add(new QATeamLead("Viktoria", "Yaroshenko", "QA Team Lead", 56284));

            foreach (Employee employee in office.Employees)
            {
                if (employee is IAssignTask || employee is ICodeReview || employee is ICodeWrite)
                {
                    Console.WriteLine($"Info: First Name - {employee.FirstName}, Last Name - {employee.LastName}, Position - {employee.Position}");
                }
            }

            //Verify that intarface methods works
            DevTeamLead dev = new DevTeamLead("Maxim", "Torop", "DEV Team lead", 43343);
            Console.WriteLine($"\nInfo");
            dev.CodeReview();
            dev.CodeWrite();
            dev.AssignTask();

            office.Employees.Sort(new SortByName());
            Console.WriteLine($"\nSorting By Name\n");
            office.Info(office.Employees);

            office.Employees.Sort(new SortByTaxId());
            Console.WriteLine($"\nSorting By TaxId\n");
            office.Info(office.Employees);

            office.Employees.Sort(new SortByNameLength());
            Console.WriteLine($"\nSorting By Name Length\n");
            office.Info(office.Employees);

            office.Employees.Sort(new SortByAssignTask());
            Console.WriteLine($"\nSorting By Assign Task\n");
            office.Info(office.Employees);

        }
    }
}
