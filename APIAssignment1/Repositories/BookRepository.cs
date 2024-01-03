using APIAssignment1.Models;

namespace APIAssignment1.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books = new List<Book>()
        {
            new Book(){BookId=121,BookName="abc",Author="qwe",Lang="English",ReleaseYear=2020,Publisher="qaz",Price=999}
        };

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(int bookId)
        {
            try
            {
                foreach (var book in books)
                {
                    if (book.BookId == bookId)
                    {
                        books.Remove(book);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditBook(Book book)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.BookId == book.BookId)
                    {
                        /*book.Author = item.BookName;
                        book.BookName = item.BookName;*/

                        item.Author=book.Author;
                        item.BookName=item.BookName;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetBookByAuthor(string author)
        {
            List<Book> book = new List<Book>();
            try
            {
                foreach (var item in books)
                {
                    if (item.Author == author)
                    {
                        book.Add(item);
                    }
                }
                return book;
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        public Book GetBookById(int id)
        {
            foreach(var book in books)
            {
                if(book.BookId==id)
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> GetBookByLanguage(string lang)
        {
            List <Book> book = new List<Book>();
            try
            {
                foreach (var item in books)
                {
                    if (item.Lang == lang)
                    {
                        book.Add(item);
                    }
                }
                return book;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book GetBookByName(string name)
        {
            foreach (var book in books)
            {
                if (book.BookName == name)
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> GetBookByYear(int year)
        {
            List<Book> book = new List<Book>();
            try
            {
                foreach (var item in books)
                {
                    if (item.ReleaseYear == year)
                    {
                        book.Add(item);
                    }
                }
                return book;
            }
            catch (Exception)
            {

                throw;
            }
          

        }
    }
}
