namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("SMS Service Sending an SMS..." + e.Video.Title);
        }
    }
}
