using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHW9
{
    class Catalog 
    {
        public List<Book> Books { get; }
        public Catalog()
        {
            Books = new List<Book>();
        }
        public void SortByBookName()
        {
            Console.WriteLine("Sort by book name:\n");
            var result = Books.OrderBy(x => x.BookName);

            foreach (var item in result)
            {
                Console.WriteLine($"Book name - {item.BookName}, Publication date - {item.PublicationDate.ToShortDateString()}, Id - {item.BookId}, Writer - {item.Writer.FullName()}");
            }
        }
        public void WritersThatHaveBooksInCatalog()
        {
            Console.WriteLine("\nList of the writers:\n");
            var authors = Books.Select(x => x.Writer.FullName()).Distinct();
        
                 foreach (var item in authors)
                 {
                     Console.WriteLine($"{item}");
                 }        
        }
        public void FindBooksByWriterAndPublicationDate(Writer writer, DateTime date)
        {
            var Writer = writer;
            var PublishDate = date;

            var result = Books.Where(x => x.Writer == Writer && x.PublicationDate > PublishDate);

            Console.WriteLine($"\nBooks of the {Writer.FullName()} published after {PublishDate.ToShortDateString()} year :\n");

            foreach (var item in result)
            {
                Console.WriteLine($"Book name - {item.BookName}, Publication date - {item.PublicationDate.ToShortDateString()}, Id - {item.BookId}, Writer - {item.Writer.FullName()}");
            }
        }
        public void SortByWriterBirthDate(Writer[] writers)
        {
            Console.WriteLine("\nSort by writer birthdate:\n");
            var result = writers.OrderBy(x => x.BirthDate);

            foreach (var item in result)
            {
                Console.WriteLine($"First Name - {item.FirstName}, Last Name - {item.LastName}, Birthdate - {item.BirthDate.ToShortDateString()}");
            }
        }
    }
}
