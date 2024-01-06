using BookAPI.Models;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books = new List<Book>()
        { new Book(){ BookId=123,BookName="asd",Author="Njyaan",Lang="English",Price=199,Year=2022} };
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(int bookId)
        {
            foreach (var book in books)
            {
                if(book.BookId == bookId)
                {
                    books.Remove(book);
                }
            }
        }

        public void EditBook(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            List<Book> book = new List<Book>();
            foreach(var item in books)
            {
                if(item.Author == author)
                {
                    book.Add(item);
                }
            }
            return book;
        }

        public List<Book> GetBooksByLang(string lang)
        {
            List<Book> book = new List<Book>();
            foreach(var item in books)
            {
                if(item.Lang==lang)
                {
                    book.Add(item);
                }
            }
            return book;
        }

        public List<Book> GetBooksByYear(int year)
        {
            List<Book> book = new List<Book>();
            foreach(var item in books)
            {
                if (item.Year == year)
                {
                    book.Add(item);
                }
            }
            return book;
        }
    }
}
