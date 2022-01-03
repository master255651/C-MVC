using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class MockReview : IReview
    {
        public IEnumerable<Review> Reviews
        {
            get
            {
                return new List<Review>
                {
                    new Review {Id = 1, IdBook = 1, Author = "Ioana Popa", PublishDate = new DateTime(2020, 6, 3, 12, 0, 0), Content = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source."},
                    new Review {Id = 2, IdBook = 1, Author = "Radu Casian", PublishDate = new DateTime(2020, 2, 10, 18, 30, 25), Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."},
                    new Review {Id = 3, IdBook = 2, Author = "Alexandru Balan", PublishDate = new DateTime(2019, 7, 20, 09, 14, 25), Content = "Cartea este foarte buna! Am citit-o cu o deosebita placere. Finalul a fost cea mare surpriza pentru mine."},
                    new Review {Id = 4, IdBook = 2, Author = "Alexandru Balan", PublishDate = new DateTime(2019, 7, 20, 09, 14, 25), Content = "Cartea este foarte buna! Am citit-o cu o deosebita placere. Finalul a fost cea mare surpriza pentru mine."},
                    new Review {Id = 5, IdBook = 3, Author = "Alexandru Balan", PublishDate = new DateTime(2019, 7, 20, 09, 14, 25), Content = "Cartea este foarte buna! Am citit-o cu o deosebita placere. Finalul a fost cea mare surpriza pentru mine."},
                    new Review {Id = 6, IdBook = 4, Author = "Alexandru Balan", PublishDate = new DateTime(2019, 7, 20, 09, 14, 25), Content = "Cartea este foarte buna! Am citit-o cu o deosebita placere. Finalul a fost cea mare surpriza pentru mine."}
                };
            }

        }
    }
}
