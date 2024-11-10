namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyeFilter;

            photoProcessor.Process("photo.jpeg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            System.Console.WriteLine("Apply Remove Red Eye");
        }
    }
}
