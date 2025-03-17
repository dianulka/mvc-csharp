using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcGooodBoooks.Data;
using MvcGooodBoooks.Models;

namespace MvcGooodBoooks.Controllers
{
    public class BookController : Controller
    {
        private readonly MvcGooodBoooksContext _context;

        public BookController(MvcGooodBoooksContext context)
        {
            _context = context;
        }

        public IActionResult TopRatedBooks()
        {
            var topRatedBooks = _context.Book
                .Include(b => b.Author) // Ensure Author is loaded
                .Include(b => b.Reviews) // Ensure Reviews are loaded
                .OrderByDescending(b => b.Reviews.Average(r => r.StarsGiven))
                .Take(3)
                .Select(b => new TopRatedBookViewModel
                {
                    Title = b.Title,
                    Author = b.Author.Name + " " + b.Author.Surname,
                    AverageRating = b.Reviews.Average(r => r.StarsGiven)
                })
                .ToList();

            return View(topRatedBooks);
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
            var books = _context.Book.Include(b => b.Author);
            return View(await books.ToListAsync());
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            PopulateAuthorsDropDownList();
            System.Diagnostics.Debug.WriteLine("This is a log");
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,AuthorId,Genre")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateAuthorsDropDownList(book.AuthorId);
            return View(book);
        }

        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            PopulateAuthorsDropDownList(book.AuthorId);
            return View(book);
        }

        // POST: Book/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,AuthorId,Genre")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book); // Attach and mark as modified
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, $"Concurrency error: {ex.Message}");
                    }
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(string.Empty, $"Update error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Unexpected error: {ex.Message}");
                }
                return RedirectToAction(nameof(Index));
            }

            PopulateAuthorsDropDownList(book.AuthorId);
            return View(book);
        }

        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if (book != null)
            {
                try
                {
                    _context.Book.Remove(book);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Delete error: {ex.Message}");
                    return View(book);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Book.Any(e => e.Id == id);
        }

        private void PopulateAuthorsDropDownList(object selectedAuthor = null)
        {
            var authorsQuery = from a in _context.Author
                               orderby a.Name
                               select a;
            ViewBag.AuthorId = new SelectList(authorsQuery.AsNoTracking(), "Id", "Name", selectedAuthor);
        }
    }
}
