using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Book 1", Price = 5 },
                new Book() { Title = "A Book 2", Price = 7 },
                new Book() { Title = "Book 3", Price = 11 },
            };
        }
    }
}
