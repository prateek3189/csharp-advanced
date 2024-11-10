namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            System.Console.WriteLine(number.HasValue);
            System.Console.WriteLine(number.GetValueOrDefault());
        }
    }
}
