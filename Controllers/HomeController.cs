// This Entire Class Was Created At This Stage 

using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}