using System.Linq;
using System.Collections.Generic;
using BooksAPI.Entities;

namespace BooksAPI.Services
{
    public static class BooksDbContextExtensions
    {
        public static void CreateSeedData 
            (this BooksDbContext content)
        {
            if (content.Books.Any())
                return;

            var books = new List<Book>()
            {
                new Book()
                {
                    Name = "Mathematic For Beginners",
                    Price = 19.55M
                },
                new Book()
                {
                    Name = "Physics For Everyone",
                    Price = 99.55M
                },
                new Book()
                {
                    Name = "Chemistry The Secret",
                    Price = 29.99M
                }
            };

            content.AddRange(books);
            content.SaveChanges();
        }
    }
}