using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW6
{
    class Buyer_debit_card: Buyer

    {
        public override string Pay()

        {
            return "Покупатель с дебетовой картой";
        }
    }
}
