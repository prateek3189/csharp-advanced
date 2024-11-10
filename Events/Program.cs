namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var smsService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
