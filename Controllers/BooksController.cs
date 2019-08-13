using Microsoft.AspNetCore.Mvc;
using BooksAPI.Services;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private BooksDbContext _context;
        public BooksController(BooksDbContext context)
        {
            _context = context;
        }

        public IActionResult GetBooks()
        {
            return Ok(_context.Books);
        }

    }
}