using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW5
{
    class Books
    {
        public string bookname { get; }
        public int amount_pages { get; }
        public string Id { get; }

    
        public Books(string name, int amount, string id )
        {
            bookname = name;
            amount_pages = amount;
            Id = id;
        }

        public string Display_Books()

        {
            return String.Format($"Название книги - {bookname}, количество страниц - {amount_pages}, уникальный идентификатор - {Id} \n");
        }


    }

}
