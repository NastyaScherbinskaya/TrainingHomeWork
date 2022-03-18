using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class QATeamLead : QAEmployee, IAssignTask
    {
        public QATeamLead(string fName, string lName, string posit) : base(fName, lName, posit) { }

    }
}
