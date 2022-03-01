using System;

namespace TrainingHW5
{
    class Program
    {
        static void Main(string[] args)
        {


            Books book1 = new Books ( "Элинор Портер - Поллианна", 105, "567" );
            Books book2 = new Books ( "Эрих Мария Ремарк - Триумфальная арка", 415, "223643" );
            Books book3 = new Books ( "Антуана де Сент-Экзюпери - Маленький принц", 60, "67439" );
            Books book4 = new Books ( "Александр Дюма - Граф Монте-Кристо", 782, "7432" );
            Books book5 = new Books ( "Александра Грин - Алые паруса", 128, "603245" );

            Books[] books = { book1, book2, book3, book4, book5 };

            foreach (Books item in books)
            {
                Console.WriteLine(item.Display_Books());
            }
        }


    }
}
