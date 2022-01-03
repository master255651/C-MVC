using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class MockBook : IBooks
    {
        private readonly ICategories _categories = new MockCategory();
        private readonly IAuthor _authors = new MockAuthor();

        public IEnumerable<Book> Books {
            get
            {
                return new List<Book>
                {
                    new Book {Id = 1, Title = "Justitia lui Cross", Description = "Detectivul Alex Cross, fost agent in cadrul FBI, se implica in rezolvarea unor cazuri pe cat de diferite, pe atat de surprinzatoare...", Price = 105.99f, Image = "Images/img1.jpg", PublishDate = 2019, Author = _authors.GetAuthorById(1), Categories = new List<Category> { _categories.GetCategoryById(1), _categories.GetCategoryById(2), _categories.GetCategoryById(3) } },
                    new Book {Id = 2, Title = "Vinovat fara vina", Description = "In timp ce executa pedeapsa pentru uciderea mamei sale - o crima pe care nu a comis-o, dupa cum sustine el -, Jacko Argyle moare de pneumonie in inchisoare. Doi ani mai tarziu, un barbat care suferise o amnezie isi face aparitia pe neasteptate si confirma alibiul lui Jacko. Se pare ca tanarul era de fapt nevinovat... iar adevaratul ucigasul face parte din familie...", Price = 135.99f, Image = "Images/img2.jpg", PublishDate = 2018, Author = _authors.GetAuthorById(2), Categories = new List<Category> { _categories.GetCategoryById(1), _categories.GetCategoryById(2) } },
                    new Book {Id = 3, Title = "A 2-a sansa", Description = "Uciderea brutala a unei fetite si a unei batrane de culoare este considerata la inceput opera unui grup rasist, si cele doua omoruri nu par sa aiba in comun decat sadismul cu care au fost comise. Detectivul Lindsay Boxer simte ca la mijloc din nou in ajutor clubul fetelor de la Crime...", Price = 98.99f, Image = "Images/img3.jpg", PublishDate = 2014, Author = _authors.GetAuthorById(1), Categories = new List<Category> { _categories.GetCategoryById(2) } },
                    new Book {Id = 4, Title = "Test book 1", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged", Price = 100.99f, Image = "Images/img4.jpg", PublishDate = 2014, Author = _authors.GetAuthorById(1), Categories = new List<Category> { _categories.GetCategoryById(2) } },
                    new Book {Id = 5, Title = "Test book 2", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged", Price = 98.99f, Image = "Images/img5.jpg", PublishDate = 2014, Author = _authors.GetAuthorById(1), Categories = new List<Category> { _categories.GetCategoryById(2) } }
                };
            }
        
        }

        public Book GetBookById(int id)
        {
            return Books.First(b => b.Id == id);
        }
    }
}
