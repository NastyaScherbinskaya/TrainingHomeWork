using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class DevTeamLead : DevEmployee, IAssignTask, ICodeReview, ICodeWrite
    {
        public DevTeamLead(string fName, string lName, string posit, int tId) : base(fName, lName, posit, tId) { }
        public void AssignTask()
        {
            Console.WriteLine("I can assign task");
        }
        public void CodeReview()
        {
            Console.WriteLine("I can review code");
        }
        public void CodeWrite()
        {
            Console.WriteLine("I can write code");
        }
    }
}
