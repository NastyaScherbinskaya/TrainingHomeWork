using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class PMEmployee : Employee, IAssignTask
    {
        public PMEmployee(string fName, string lName, string posit, int tId) : base(fName, lName, posit, tId) { }
        public void AssignTask()
        {
            Console.WriteLine("I can assign task");
        }
    }
}
