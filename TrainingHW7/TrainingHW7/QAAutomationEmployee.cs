using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class QAAutomationEmployee : Employee, ICodeWrite
    {
        public QAAutomationEmployee(string fName, string lName, string posit) : base(fName, lName, posit) { }

        public void CodeWrite()
        {
            Console.WriteLine("I can write code");
        }
    }
}
