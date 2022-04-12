using System;

namespace TrainingHW9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

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

            Writer[] writers = {writer1, writer2, writer3, writer4, writer5, writer6,writer7};

            catalog.SortByBookName();
            catalog.WritersThatHaveBooksInCatalog();

            var WriterForFind = writer1;
            DateTime PublicationDate = DateTime.Parse("01.01.2000");
            try
            {
                catalog.FindBooksByWriterAndPublicationDate(WriterForFind, PublicationDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            catalog.SortByWriterBirthDate(writers);

            Console.WriteLine("\nAdd new book:");

            var NewBookName = "Гордость и предубеждение";
            var NewPublishDate = DateTime.Parse("04.06.1813");
            var NewID = 8;
            Writer NewWriter = new Writer("Джейн", "Остин", DateTime.Parse("16.12.1775"));
            try
            {
                catalog.AddNewBook(NewBookName, NewPublishDate, NewID, NewWriter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
