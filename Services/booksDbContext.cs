using Microsoft.EntityFrameworkCore;
using BooksAPI.Entities;

namespace BooksAPI.Services 
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}