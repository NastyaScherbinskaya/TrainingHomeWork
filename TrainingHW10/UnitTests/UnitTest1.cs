using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TrainingHW9;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Catalog catalog = new Catalog();

        [TestMethod]
        public void ValidSortingByBookName()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));
            var writer3 = new Writer("Федор", "Достоевский", DateTime.Parse("11.11.1821"));
            var writer4 = new Writer("Антуан", "де Сент-Экзюпери", DateTime.Parse("29.06.1900"));
            var writer5 = new Writer("Оскар", "Уайльд", DateTime.Parse("16.10.1854"));
            var writer6 = new Writer("Джейн", "Остин", DateTime.Parse("16.12.1775"));
            var writer7 = new Writer("Рей", "Брэдбери", DateTime.Parse("22.08.1920"));

            catalog.Books.Add(new Book("Триумфальная арка", DateTime.Parse("01.01.1946"), 1, writer1)); 
            catalog.Books.Add(new Book("Три товарища", DateTime.Parse("03.10.1936"), 2, writer1)); 
            catalog.Books.Add(new Book("Искра Жизни", DateTime.Parse("23.05.1952"), 3, writer1));
            catalog.Books.Add(new Book("Мастер и Маргарита", DateTime.Parse("09.08.1967"), 4, writer2));
            catalog.Books.Add(new Book("Преступление и наказание", DateTime.Parse("16.08.1866"), 5, writer3));
            catalog.Books.Add(new Book("Маленький принц", DateTime.Parse("30.01.1943"), 6, writer4));
            catalog.Books.Add(new Book("Портрет Дориана Грея", DateTime.Parse("10.10.1890"), 7, writer5));
            catalog.Books.Add(new Book("Гордость и предубеждение", DateTime.Parse("04.06.1813"), 8, writer6));

            Book[] ExpectedResult = { catalog.Books[7], catalog.Books[2], catalog.Books[5], catalog.Books[3],catalog.Books[6],catalog.Books[4], catalog.Books[1], catalog.Books[0]};
            var ActualResult = catalog.SortByBookName();

            //Assert.IsTrue(ExpectedResult.SequenceEqual(ActualResult));

            for (int i = 0; i < catalog.Books.Count(); i++)
            {
               Assert.AreEqual(ExpectedResult[i],(ActualResult[i]));
            }
        }

        [TestMethod]
        public void ValidListWritersThatHaveBooksInCatalog()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));
            var writer3 = new Writer("Федор", "Достоевский", DateTime.Parse("11.11.1821"));
            var writer4 = new Writer("Антуан", "де Сент-Экзюпери", DateTime.Parse("29.06.1900"));

            catalog.Books.Add(new Book("Триумфальная арка", DateTime.Parse("01.01.1946"), 1, writer1));
            catalog.Books.Add(new Book("Мастер и Маргарита", DateTime.Parse("09.08.1967"), 4, writer2));
            catalog.Books.Add(new Book("Преступление и наказание", DateTime.Parse("16.08.1866"), 5, writer3));

            string[] ExpectedResult = {"Эрих Мария Ремарк","Михаил Булгаков", "Федор Достоевский" };

            var ActualResult = catalog.WritersThatHaveBooksInCatalog();

            Assert.IsTrue(ExpectedResult.SequenceEqual(ActualResult));
        }

        [TestMethod]
        public void NoAnyBooksHaveBeenFoundByWriterAndPublicationDate()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));
            var writer3 = new Writer("Федор", "Достоевский", DateTime.Parse("11.11.1821"));

            catalog.Books.Add(new Book("Триумфальная арка", DateTime.Parse("01.01.1946"), 1, writer1));
            catalog.Books.Add(new Book("Три товарища", DateTime.Parse("03.10.1936"), 2, writer1));
            catalog.Books.Add(new Book("Искра Жизни", DateTime.Parse("23.05.1952"), 3, writer1));
            catalog.Books.Add(new Book("Мастер и Маргарита", DateTime.Parse("09.08.1967"), 4, writer2));
            catalog.Books.Add(new Book("Преступление и наказание", DateTime.Parse("16.08.1866"), 5, writer3));

            var WriterForFind = writer2;
            DateTime PublicationDate = DateTime.Parse("01.01.2000");

            var ex = Assert.ThrowsException<Exception>(() => catalog.FindBooksByWriterAndPublicationDate(WriterForFind, PublicationDate));
            Assert.AreEqual("No any writer has been found", ex.Message);
        }

        [TestMethod]
        public void BooksHaveBeenFoundByWriterAndPublicationDate()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));
            var writer3 = new Writer("Федор", "Достоевский", DateTime.Parse("11.11.1821"));

            catalog.Books.Add(new Book("Триумфальная арка", DateTime.Parse("01.01.1946"), 1, writer1));
            catalog.Books.Add(new Book("Три товарища", DateTime.Parse("03.10.1936"), 2, writer1));
            catalog.Books.Add(new Book("Искра Жизни", DateTime.Parse("23.05.1952"), 3, writer1));
            catalog.Books.Add(new Book("Мастер и Маргарита", DateTime.Parse("09.08.1967"), 4, writer2));
            catalog.Books.Add(new Book("Преступление и наказание", DateTime.Parse("16.08.1866"), 5, writer3));

            var WriterForFind = writer1;
            DateTime PublicationDate = DateTime.Parse("01.01.1940");

            Book[] ExpectedResult = {catalog.Books[0],catalog.Books[2]};
            var ActualResult = catalog.FindBooksByWriterAndPublicationDate(WriterForFind, PublicationDate);

            Assert.IsTrue(ExpectedResult.SequenceEqual(ActualResult));
        }

        [TestMethod]
        public void ValidSortingByWriterBirthdate()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));
            var writer3 = new Writer("Федор", "Достоевский", DateTime.Parse("11.11.1821"));
            var writer4 = new Writer("Антуан", "де Сент-Экзюпери", DateTime.Parse("29.06.1900"));
            var writer5 = new Writer("Оскар", "Уайльд", DateTime.Parse("16.10.1854"));

            Writer[] writers = { writer1, writer2, writer3, writer4, writer5};

            Writer[] ExpectedResult = {writer3, writer5, writer2, writer1, writer4};
            var ActualResult = catalog.SortByWriterBirthDate(writers);

            Assert.IsTrue(ExpectedResult.SequenceEqual(ActualResult));
        }

        [TestMethod]
        public void NotValidAddNewBook()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));
            var writer3 = new Writer("Федор", "Достоевский", DateTime.Parse("11.11.1821"));

            catalog.Books.Add(new Book("Триумфальная арка", DateTime.Parse("01.01.1946"), 1, writer1));
            catalog.Books.Add(new Book("Три товарища", DateTime.Parse("03.10.1936"), 2, writer1));
            catalog.Books.Add(new Book("Искра Жизни", DateTime.Parse("23.05.1952"), 3, writer1));
            catalog.Books.Add(new Book("Мастер и Маргарита", DateTime.Parse("09.08.1967"), 4, writer2));
            catalog.Books.Add(new Book("Преступление и наказание", DateTime.Parse("16.08.1866"), 5, writer3));

            var NewBookName = "Триумфальная арка";
            var NewPublishDate = DateTime.Parse("01.01.1946");
            var NewID = 1;
            Writer NewWriter = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));

            var ex = Assert.ThrowsException<Exception>(() => catalog.AddNewBook(NewBookName, NewPublishDate, NewID, NewWriter));
            Assert.AreEqual("\nThe book can't be added. There is the same book in collection.", ex.Message);
        }

        [TestMethod]
        public void ValidAddNewBook()
        {
            var writer1 = new Writer("Эрих Мария", "Ремарк", DateTime.Parse("22.06.1898"));
            var writer2 = new Writer("Михаил", "Булгаков", DateTime.Parse("15.05.1891"));

            catalog.Books.Add(new Book("Три товарища", DateTime.Parse("03.10.1936"), 2, writer1));
            catalog.Books.Add(new Book("Мастер и Маргарита", DateTime.Parse("09.08.1967"), 4, writer2));

            var NewBookName = "Доводы Рассудка";
            var NewPublishDate = DateTime.Parse("14.10.1817");
            var NewID = 88;
            Writer NewWriter = new Writer("Джейн", "Остин", DateTime.Parse("16.12.1775"));

            bool ActualResult = catalog.AddNewBook(NewBookName, NewPublishDate, NewID, NewWriter);
            Assert.AreEqual(true, ActualResult);
        }
    }
}