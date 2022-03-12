using System;

namespace TrainingHW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book ( "Элинор Портер - Поллианна", 105, "567" );
            Book book2 = new Book ( "Эрих Мария Ремарк - Триумфальная арка", 415, "223643" );
            Book book3 = new Book ( "Антуана де Сент-Экзюпери - Маленький принц", 60, "67439" );
            Book book4 = new Book ( "Александр Дюма - Граф Монте-Кристо", 782, "7432" );
            Book book5 = new Book ( "Александра Грин - Алые паруса", 128, "603245" );

            Book[] books = { book1, book2, book3, book4, book5 };

            foreach (Book item in books)
            {
                item.DisplayBooks();
            }
        }

    }
}
