using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class MockAuthor : IAuthor
    {
        public IEnumerable<Author> Authors
        {
            get
            {
                return new List<Author>
                {
                    new Author {Id = 1, FirstName = "James", LastName = "Patterson"},
                    new Author {Id = 2, FirstName = "Agatha", LastName = "Christie"}
                };
            }

        }

        public Author GetAuthorById(int id)
        {
            return Authors.First(a => a.Id == id);
        }

        public IEnumerable<Book> BooksOfAuthor(IEnumerable<Book> books, int idAuthor)
        {
            return books.Where(b => b.Author.Id == idAuthor);
        }
    }
}
