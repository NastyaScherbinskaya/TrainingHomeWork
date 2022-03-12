using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW5
{
    class Book
    {
        public string BookName { get; }
        public int AmountPages { get; }
        public string Id { get; }

    
        public Book(string name, int amount, string id )
        {
            BookName = name;
            AmountPages = amount;
            Id = id;
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Название книги - {BookName}, количество страниц - {AmountPages}, уникальный идентификатор - {Id} \n");
        }

    }

}
