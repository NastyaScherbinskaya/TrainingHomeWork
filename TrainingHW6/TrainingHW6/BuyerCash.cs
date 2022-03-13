using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW6
{
    class BuyerCash: Buyer
    {
        public override void Pay() 
        {
            Console.WriteLine("Buyer by cash");
        }
    }
}
