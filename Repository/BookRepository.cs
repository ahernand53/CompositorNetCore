using System.Collections.Generic;
using System.Linq;
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
                new Book()
                {
                    Id = 1, 
                    Title = "Mvc", 
                    Author = "Nitish", 
                    Description = "This is the description for MVC book", 
                    Category = "Programing", 
                    Language = "Germany", 
                    TotalPages = 1500
                },
                new Book()
                {
                    Id = 2, 
                    Title = "C#", 
                    Author = "Nitish", 
                    Description = "This is the description for C# book", 
                    Category = "Programing", 
                    Language = "English", 
                    TotalPages = 1002
                },
                new Book()
                {
                    Id = 3, 
                    Title = ".Net core", 
                    Author = "Nitish", 
                    Description = "This is the description for .Net core book", 
                    Category = "Programing", 
                    Language = "British", 
                    TotalPages = 976
                },
                new Book()
                {
                    Id = 4, 
                    Title = "Java", 
                    Author = "Nitish", 
                    Description = "This is the description for Java book", 
                    Category = "Programing", 
                    Language = "French", 
                    TotalPages = 2421
                },
                new Book()
                {
                    Id = 5, 
                    Title = "Php", 
                    Author = "Nitish", 
                    Description = "This is the description for Php book", 
                    Category = "Programing", 
                    Language = "Spanish", 
                    TotalPages = 1254
                },
            };
        }
    }
}
