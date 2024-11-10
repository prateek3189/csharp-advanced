namespace Lambda
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Book 1", Price = 5 },
                new Book() { Title = "Book 2", Price = 7 },
                new Book() { Title = "Book 3", Price = 11 },
            };
        }
    }
}
