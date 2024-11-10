namespace Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooks)
            {
                System.Console.WriteLine(book.Title);
            }
        }
    }
}
