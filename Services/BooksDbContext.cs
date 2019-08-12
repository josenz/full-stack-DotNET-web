using Microsoft.EntityFrameworkCore;
using BooksAPI.Entities;

namespace BooksAPI.Services
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

    }
}