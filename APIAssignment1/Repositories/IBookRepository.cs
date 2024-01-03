using APIAssignment1.Models;

namespace APIAssignment1.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        List<Book> GetBookByAuthor(string author);
        List<Book> GetBookByLanguage(string lang);
        Book GetBookByName(string name);
        Book GetBookById(int id);

        List<Book> GetBookByYear(int year);
        void EditBook(Book book);
        void DeleteBook(int bookId);
    }
}
