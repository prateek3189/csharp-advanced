namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("Mail Service Sending an Email..." + e.Video.Title);
        }
    }
}
