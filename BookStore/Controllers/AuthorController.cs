using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IBooks _books;
        private readonly IAuthor _author;

        public AuthorController(IBooks books, IAuthor author)
        {
            _books = books;
            _author = author;
        }

        [HttpGet("/Author/AuthorBooks/{id?}")]
        public IActionResult AuthorBooks(int id)
        {
            var books = _author.BooksOfAuthor(_books.Books, id);
            return View(books);
        }
    }
}
