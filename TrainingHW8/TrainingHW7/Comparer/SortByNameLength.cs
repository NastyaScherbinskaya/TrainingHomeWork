using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7.Comparer
{
    class SortByNameLength : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            var xFullName = x.FirstName.Length + x.LastName.Length;
            var yFullName = y.FirstName.Length + y.LastName.Length;

            if (xFullName < yFullName)
            {
                return 1;
            }
            if (xFullName == yFullName)
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
