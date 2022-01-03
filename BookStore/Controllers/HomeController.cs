using BookStore.Interfaces;
using BookStore.Models;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBooks _books;
        private readonly ICategories _categories;
        private readonly IAuthor _authors;

        public HomeController(ILogger<HomeController> logger, IBooks books, ICategories categories, IAuthor authors)
        {
            _logger = logger;
            _books = books;
            _categories = categories;
            _authors = authors;
        }

        [HttpGet("/Pages/{id?}")]
        public IActionResult Index(int id)
        {
            BooksCategoriesAuthorsViewModel obj = new BooksCategoriesAuthorsViewModel();
            obj.NeededBooks = _books.Books.Skip( (id - 1) * 3 ).Take(3);
            obj.AllBooks = _books.Books;
            obj.AllAuthors = _authors.Authors;
            obj.AllCategories = _categories.Categories;
            obj.Categories = _categories;
            obj.Author = _authors;
            return View(obj);
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
    }
}
