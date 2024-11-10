using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2- Define an Event based on delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // 3- Raise the Evenet
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
            System.Console.WriteLine("Encoding Completes");
        }
    }
}
