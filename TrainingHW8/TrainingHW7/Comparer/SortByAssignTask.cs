using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW8.Comparer
{
    class SortByAssignTask : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x is IAssignTask && y is IAssignTask)
            {
                if (x.LastName[0] > y.LastName[0])
                {
                    return 1;
                }
            }

            if (x is not IAssignTask && y is not IAssignTask)
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
