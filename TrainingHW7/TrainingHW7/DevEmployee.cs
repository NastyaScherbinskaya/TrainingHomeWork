using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7
{
    class DevEmployee : Employee, ICodeWrite
    {
        public DevEmployee(string fName, string lName, string posit, int tId) : base(fName, lName, posit, tId) { }
        public void CodeWrite()
        {
            Console.WriteLine("I can write code");
        }
    }
}
