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
        public DateTime PublicationDate { get; }
        public int BookId { get; }
        public string WriterName { get; }

        public Book(string name, DateTime date, int id, string author)
        {
            BookName = name;
            PublicationDate = date;
            BookId = id;
            WriterName = author;
        }
    }
}
