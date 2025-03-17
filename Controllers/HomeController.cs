using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcGooodBoooks.Models;
using MvcGooodBoooks.Data;
using MvcGooodBoooks.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGooodBoooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcGooodBoooksContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly BookController _bookService;

        public HomeController(ILogger<HomeController> logger, MvcGooodBoooksContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> TopRatedBooks()
        {
            var topRatedBooks = await _context.Book
                                    .Select(b => new
                                    {
                                        Book = b,
                                        AverageRating = _context.Review
                                                                .Where(r => r.BookId == b.Id)
                                                                .Average(r => (double?)r.StarsGiven) ?? 0
                                    })
                                    .OrderByDescending(b => b.AverageRating)
                                    .Take(1)
                                    .ToListAsync();
            
            

            var viewModel = topRatedBooks.Select(b => new TopRatedBookViewModel
            {
                Title = b.Book.Title,
                Author = $"{b.Book.Author.Name} {b.Book.Author.Surname}",
                AverageRating = b.AverageRating
            }).ToList();

            return View(viewModel);
        }


    }
}
