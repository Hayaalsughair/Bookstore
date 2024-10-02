using Bookstore.Data;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;
        public BooksController(AppDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    var books = _context.Books.ToList();
        //    return View(books);
        //}
        public IActionResult Index(string searchTerm)
        {
            var books = _context.Books.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                books = books.Where(b => b.Title.Contains(searchTerm) || b.Author.Contains(searchTerm));
            }

            return View(books.ToList());
        }

        public IActionResult Details(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        public IActionResult CreateBook()
        {
            var model = new Book();
            return View(model);       
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
        public IActionResult EditBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                var existingBook = _context.Books.FirstOrDefault(b => b.Id == book.Id);

                if (existingBook == null)
                {
                    return NotFound();
                }

                // Update the book details
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Price = book.Price;
                existingBook.Genre = book.Genre;

                _context.SaveChanges();

                return RedirectToAction("Details", new { id = existingBook.Id });
            }

            return View(book);
        }
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();

            return View("Index");
        }

    }
}
