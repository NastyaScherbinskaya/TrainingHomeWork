﻿using System;
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
             Console.WriteLine($"Book name - {item.BookName}, Publication date - {item.PublicationDate}, Id - {item.BookId}, Writer - {item.Writer}");
            }
        }
        public void WritersThatHaveBooksInCatalog(Writer[] writers)
        {
            Console.WriteLine("\nList of the writers:\n");

            foreach (var i in writers)
            {
                foreach (var book in Books)
                {
                    if (i.FirstName + " " + i.LastName == book.Writer)
                    {
                        Console.WriteLine($"{ book.Writer}");
                        break;
                    }
                }
            }
        }
        public void FindBooksByWriterAndPublicationDate(string name, int date)
        {
            var WriterName = name;
            var PublishDate = date;

            var result = Books.Where(x => x.Writer == WriterName && x.PublicationDate > PublishDate);

            Console.WriteLine($"\nBooks of the {WriterName} published after {PublishDate} year :\n");

            foreach (var item in result)
            {
                Console.WriteLine($"Book name - {item.BookName}, Publication date - {item.PublicationDate}, Id - {item.BookId}, Writer - {item.Writer}");
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
