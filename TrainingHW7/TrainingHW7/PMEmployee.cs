using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class PMEmployee : Employee, IAssignTask
    {
        public PMEmployee(string fName, string lName, string posit) : base(fName, lName, posit) { }
    }

}
