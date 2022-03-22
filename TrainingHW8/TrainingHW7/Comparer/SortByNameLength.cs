using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW8.Comparer
{
    class SortByNameLength : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if ((x.FirstName.Length + x.LastName.Length) < (y.FirstName.Length + y.LastName.Length))
            {
                return 1;
            }
            else if ((x.FirstName.Length + x.LastName.Length) == (y.FirstName.Length + y.LastName.Length))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
