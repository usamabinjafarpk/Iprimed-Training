using BookAPI.Models;
namespace BookAPI.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book books);
        List<Book> GetAllBooks();
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByLang(string lang);
        List<Book> GetBooksByYear(int year);
        void EditBook(Book book);
        void DeleteBook(int bookId);
    }
}
