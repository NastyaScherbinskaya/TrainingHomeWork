﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class QAAutomationTeamLead : QAAutomationEmployee, ICodeReview, ICodeWrite, IAssignTask
    {
        public QAAutomationTeamLead(string fName, string lName, string posit) : base(fName, lName, posit) { }
    }
}
