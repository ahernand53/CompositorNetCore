using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ytWebGentile.Models;

namespace ytWebGentile.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks() 
        {
            return DataSource();
        }

        public Book GetBookById(int id)
        {
            return DataSource()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public List<Book> SearchBook(string title, string authorName)
        {
            return DataSource()
                .Where(
                    x => x.Title == title 
                    && x.Author.Contains(authorName)
                )
                .ToList();
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){Id = 1, Title = "Mvc", Author = "Nitish"},
                new Book(){Id = 2, Title = "C#", Author = "Nitish"},
                new Book(){Id = 3, Title = ".Net core", Author = "Nitish"},
                new Book(){Id = 4, Title = "Java", Author = "Nitish"},
                new Book(){Id = 5, Title = "Php", Author = "Nitish"},
            };
        }
    }
}
