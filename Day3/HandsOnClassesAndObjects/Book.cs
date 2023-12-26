using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Book
    {
        public int BookId;
        public string BookName;
        public string Language;
        public int Price;
        public string Author;
        public string Publisher;
    }
    class BookRepository
    {
        public Book[] books = new Book[5];
        public int idx = 0;
        public void AddBook(Book book)
        {
            if(idx<=books.Length)
            {
                books[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("Book is Full");
            }
        }
        public Book[] GetBookByName(string name)
        {
            Book[] book_name= new Book[books.Length];
            int idx = 0;
            foreach(Book book in books)
            {
                if(book!=null)
                {
                    if(book.BookName==name)
                    {
                        book_name[idx] = book;
                        idx++;
                    }
                }
            }
            return book_name;
        }
        public Book[] GetBookByAuthor(string author)
        {
            Book[] book_author= new Book[books.Length];
            int idx = 0;
            foreach( Book book in books)
            {
                if(book!=null)
                {
                    if(book.Author==author)
                    {
                        book_author[idx] = book;
                        idx++;
                    }
                }
            }
            return book_author;
        }
        public Book[] GetBooksByPublisher(string publisher)
        {
            Book[] book_publisher= new Book[books.Length];
            int idx = 0;
            foreach(Book book in books)
            {
                if(book != null)
                {
                    if (book.Publisher == publisher)
                    {
                        book_publisher[idx] = book;
                        idx++;
                    }
                }
            }
            return book_publisher;
        }
    }
}
