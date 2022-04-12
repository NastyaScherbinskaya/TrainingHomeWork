using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace TrainingHW9
{
    public class Catalog
    {
        List<Book> _books;
        public List<Book> Books
        {
            get
            {
                return _books;
            }
        }
        public Catalog()
        {
            _books = new List<Book>();
        }
        public Book[] SortByBookName()
        {
            Console.WriteLine("Sort by book name:\n");
            var result = Books.OrderBy(x => x.BookName).ToArray();

            foreach (var item in result)
            {
                Console.WriteLine($"Book name - {item.BookName}, Publication date - {item.PublicationDate.ToShortDateString()}, Id - {item.BookId}, Writer - {item.Writer.FullName()}");
            }
            return result;
        }
        public string[] WritersThatHaveBooksInCatalog()
        {
            Console.WriteLine("\nList of the writers:\n");
            var authors = Books.Select(x => x.Writer.FullName()).Distinct().ToArray();

            foreach (var item in authors)
            {
                Console.WriteLine($"{item}");
            }
            return authors;
        }
        public Book[] FindBooksByWriterAndPublicationDate(Writer writer, DateTime date)
        {
            var Writer = writer;
            var PublishDate = date;

            var result = Books.Where(x => x.Writer == Writer && x.PublicationDate > PublishDate).ToArray();

            Console.WriteLine($"\nBooks of the {Writer.FullName()} published after {PublishDate.ToShortDateString()} year :\n");

            if (result.Count() == 0)
            {
                throw new Exception("No any writer has been found");
            }
            else
            { 
                foreach (var item in result)
                {
                    Console.WriteLine($"Book name - {item.BookName}, Publication date - {item.PublicationDate.ToShortDateString()}, Id - {item.BookId}, Writer - {item.Writer.FullName()}");
                }
            }
            return result;
        }
        public Writer[] SortByWriterBirthDate(Writer[] writers)
        {
            Console.WriteLine("\nSort by writer birthdate:\n");
            var result = writers.OrderBy(x => x.BirthDate).ToArray();

            foreach (var item in result)
            {
                Console.WriteLine($"First Name - {item.FirstName}, Last Name - {item.LastName}, Birthdate - {item.BirthDate.ToShortDateString()}");
            }
            return result;
        }
        public bool AddNewBook(string name, DateTime date, int id, Writer author)
        {
             var result = Books.Find(x => x.BookId == id);
             if (result == null)
             {
                 Books.Add(new Book(name, date, id, author));
                 Console.WriteLine("\nNew book was added.");
                 return true;
             }
             else
             {
                throw new Exception("\nThe book can't be added. There is the same book in collection.");
             }
        }
    }
}
