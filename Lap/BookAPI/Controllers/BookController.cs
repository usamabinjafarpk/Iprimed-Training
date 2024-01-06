using BookAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Models;
namespace BookAPI.Controllers
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
        [HttpGet("GetAllBook")]
        public IActionResult GetAllBooks()
        {
            List<Book> books=bookRepository.GetAllBooks();
            return StatusCode(200, books);
        }
        [HttpPost("AddBook")]
        public IActionResult AddBook(Book book)
        {
            bookRepository.AddBook(book);
            return StatusCode(200,book);
        }
        [HttpGet("GetBookBYAuthor/{name}")]
        public IActionResult GetBooksByAuthor(string name)
        {
            return StatusCode(200, bookRepository.GetBooksByAuthor(name));
        }
        [HttpGet("GetBookByLanguage/{lang}")]
        public IActionResult GetBooksByLang(string lang)
        {
            return StatusCode(200, bookRepository.GetBooksByLang(lang));
        }
        [HttpGet("GetBookByYear")]
        public IActionResult GetBooksByYear(int year)
        {
            return StatusCode(200, bookRepository.GetBooksByYear(year));
        }
    }
}
