using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IBooks _books;
        private readonly ICategories _categories;

        public CategoryController(IBooks books, ICategories categories)
        {
            _books = books;
            _categories = categories;
        }

        [HttpGet("/Category/CategoryBooks/{id?}")]
        public IActionResult CategoryBooks(int id)
        {
            var books = _categories.BooksOfCategory(_books.Books, id);
            return View(books);
        }
    }
}
