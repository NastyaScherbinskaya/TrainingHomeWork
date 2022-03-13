using System;

namespace TrainingHW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer1 = new BuyerCash();
            Buyer buyer2 = new BuyerCreditCard();
            Buyer buyer3 = new BuyerCash();
            Buyer buyer4 = new BuyerDebitCard();
            Buyer buyer5 = new BuyerDebitCard();

            Buyer[] buyer = { buyer1, buyer2, buyer3, buyer4, buyer5 };

            foreach (Buyer item in buyer)
            {
                item.Pay();
            }   
        }
    }
}
