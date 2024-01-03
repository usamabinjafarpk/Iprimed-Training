using APIAssignment1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAssignment1.Models;

namespace APIAssignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        [HttpPost("AddBook")]
        public IActionResult Add(Book book)
        {
            bookRepository.AddBook(book);
            return StatusCode(200, book);
        }
        [HttpGet("GetAllBook")]
        public IActionResult GetAllBooks()
        {
            List<Book> books = bookRepository.GetAllBooks();
            return StatusCode(200, books);
        }
        [HttpGet("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            return StatusCode(200,bookRepository.GetBookByAuthor(author));
        }
        [HttpGet("GetBookByLanguage/{lang}")]

        public IActionResult GetBookByLang(string lang)
        {
            return StatusCode(200, bookRepository.GetBookByLanguage(lang));
        }
        [HttpGet("GetBookByYear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
            return StatusCode(200, bookRepository.GetBookByYear(year));
        }
        [HttpPut("EditBook")]
        public IActionResult EditBook(Book book)
        {
            bookRepository.EditBook(book);
            return StatusCode(200, book);
        }
        [HttpDelete("DeleteBook/{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            bookRepository.DeleteBook(bookId);
            return StatusCode(200, "Book deleted successfully");
        }
    }
}
