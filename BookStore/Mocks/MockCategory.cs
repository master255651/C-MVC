using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class MockCategory : ICategories
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {Id = 1, Title = "Crime"},
                    new Category {Id = 2, Title = "Thriller"},
                    new Category {Id = 3, Title = "Mystery"}
                };
            }

        }

        public Category GetCategoryById(int id)
        {
            return Categories.First(c => c.Id == id);
        }

        public IEnumerable<Book> BooksOfCategory(IEnumerable<Book> books, int idCategory)
        {
            List<Book> booksOfCategory = new List<Book>();

            foreach(Book book in books)
            {
                foreach (Category category in book.Categories)
                {
                    if(category.Id == idCategory)
                    {
                        booksOfCategory.Add(book);
                    }
                }
            }
            return booksOfCategory;
        }
    }
}
