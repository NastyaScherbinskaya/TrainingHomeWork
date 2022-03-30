using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class QAAutomationTeamLead : QAAutomationEmployee, ICodeReview, ICodeWrite, IAssignTask
    {
        public QAAutomationTeamLead(string fName, string lName, string posit) : base(fName, lName, posit) { }
        public void CodeWrite()
        {
            Console.WriteLine("I can write code");
        }
        public void AssignTask()
        {
            Console.WriteLine("I can assign task");
        }
        public void CodeReview()
        {
            Console.WriteLine("I can review code");
        }
    } 
}
