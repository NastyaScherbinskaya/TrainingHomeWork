using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW7.Comparer
{
    class SortByTaxId : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.TaxId > y.TaxId)
            {
                return 1;
            }
            if (x.TaxId == y.TaxId)
            {
                return 0;
            }
            {
                return -1;
            }
        }
    }
}
