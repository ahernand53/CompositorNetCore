using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ytWebGentile.Models;
using ytWebGentile.Repository;

namespace ytWebGentile.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ViewResult GetAllBooks()
        {

            var data = _bookRepository.GetAllBooks();

            return View(data);

        }

        [Route("book-details/{id}")]
        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);

            return View(data);
        }

        public List<Book> searchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }

        [HttpPost]
        public IActionResult AddNewBook(Book book)
        {
            int id = _bookRepository.AddNewBook(book);

            if (id > 0)
            {
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
            }

            return View();
        }

        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;

            return View();
        }
}
}
