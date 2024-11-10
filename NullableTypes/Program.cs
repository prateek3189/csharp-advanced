namespace Nullable
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            System.Console.WriteLine(date2.ToString());
        }
    }
}
