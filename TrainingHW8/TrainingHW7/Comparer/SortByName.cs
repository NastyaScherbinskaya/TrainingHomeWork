using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW8.Comparer
{
    class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.FirstName[0] < y.FirstName[0])
            {
                return -1;
            }
            else if (x.FirstName[0] == y.FirstName[0])
            {
                return 0;
            }
            else 
            {
                return 1;
            }
        }
    }
}
