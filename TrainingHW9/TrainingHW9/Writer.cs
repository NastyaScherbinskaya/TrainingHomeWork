using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW9
{
    class Writer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public Writer(string fname, string lname, DateTime dateTime)
        {
            FirstName = fname;
            LastName = lname;
            BirthDate = dateTime;
        }
    }
}
