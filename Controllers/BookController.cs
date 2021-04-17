using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ytWebGentile.Models;
using ytWebGentile.Repository;

namespace ytWebGentile.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public List<Book> GetAllBooks() 
        {

            return _bookRepository.GetAllBooks();
            
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<Book> searchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
