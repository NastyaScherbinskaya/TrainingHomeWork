using System;

namespace TrainingHW6
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 1;

            Buyer buyer1 = new Buyer_cash();
            Buyer buyer2 = new Buyer_credit_card();
            Buyer buyer3 = new Buyer_cash();
            Buyer buyer4 = new Buyer_debit_card();
            Buyer buyer5 = new Buyer_debit_card();

            Buyer[] buyer = { buyer1, buyer2, buyer3, buyer4, buyer5 };

            foreach (Buyer item in buyer)

            {
                Console.WriteLine($"Покупатель {number} - {item.Pay()}\n");
                number++;
            }

           
        }
    }
}
