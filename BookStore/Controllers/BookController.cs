using BookStore.Interfaces;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.ViewModels;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooks _books;
        private readonly IReview _reviews;

        public BookController(IBooks books, IReview review)
        {
            _books = books;
            _reviews = review;
        }

        [HttpGet("/Book/BookDetails/{id?}")]
        public IActionResult BookDetails(int id)
        {
            ReviewBookViewModel obj = new ReviewBookViewModel();
            obj.Book = _books.GetBookById(id);
            obj.Reviews = _reviews.Reviews.Where(r => r.IdBook == id);
            return View(obj);
        }

    }
}
