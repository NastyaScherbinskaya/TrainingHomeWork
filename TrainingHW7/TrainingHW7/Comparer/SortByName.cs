using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7.Comparer
{
    class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.FirstName[0] < y.FirstName[0])
            {
                return -1;
            }
            if (x.FirstName[0] == y.FirstName[0])
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
