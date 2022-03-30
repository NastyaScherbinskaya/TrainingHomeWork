using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW9
{
    class Book
    {
        public string BookName { get; }
        public int PublicationDate { get; }
        public int BookId { get; }
        public string Writer { get; }

        public Book(string name, int date, int id, string author)
        {
            BookName = name;
            PublicationDate = date;
            BookId = id;
            Writer = author;
        }
    }
}
