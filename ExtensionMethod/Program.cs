namespace ExtensionMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            string post =
                "Lorem ipsum dolor sit amet, consectetur adip occurence velit lobortis nisl, sed diam nonumy";
            var shortenPost = post.Shorten(10);

            System.Console.WriteLine(shortenPost);
        }
    }
}
