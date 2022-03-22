using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW8
{
    class QAAutomationTeamLead : QAAutomationEmployee, ICodeReview, ICodeWrite, IAssignTask
    {
        public QAAutomationTeamLead(string fName, string lName, string posit, int tId) : base(fName, lName, posit, tId) { }
    }
}
