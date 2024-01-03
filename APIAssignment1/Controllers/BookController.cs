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
            try
            {
                bookRepository.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetAllBook")]
        public IActionResult GetAllBooks()
        {
            List<Book> books = bookRepository.GetAllBooks();
            try
            {
                return StatusCode(200, books);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByAuthor(author));
            }
            catch(Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetBookByLanguage/{lang}")]

        public IActionResult GetBookByLang(string lang)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByLanguage(lang));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetBookByYear/{year}")]
        public IActionResult GetBookByYear(int year)
        {
            try
            {
                return StatusCode(200, bookRepository.GetBookByYear(year));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPut("EditBook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                bookRepository.EditBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete("DeleteBook/{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            try
            {
                bookRepository.DeleteBook(bookId);
                return StatusCode(200, "Book deleted successfully");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetBookById/{id}")]
        public IActionResult GetBookById(int id)
        {
            Book book = bookRepository.GetBookById(id);
            if(book!=null)
            {
                return StatusCode(200, book);
            }
            else
            {
                return StatusCode(405);
            }
        }
        [HttpGet("GetBookByName/{name}")]
        public IActionResult GetBookByName(string name)
        {
            Book book = bookRepository.GetBookByName(name);
            if (book != null)
            {
                return StatusCode(200, book);
            }
            else
            {
                return StatusCode(405);
            }
        }
    }
}
