using System.IO;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"/somepath"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Some Cleanup
                streamReader.Dispose();
            }
        }
    }
}
