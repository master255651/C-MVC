﻿using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class BooksCategoriesAuthorsViewModel
    {
        public ICategories Categories { get; set; }
        public IAuthor Author { get; set; }
        public IEnumerable<Book> AllBooks { get; set; }
        public IEnumerable<Book> NeededBooks { get; set; }
        public IEnumerable<Category> AllCategories { get; set; }
        public IEnumerable<Author> AllAuthors { get; set; }
    }
}
