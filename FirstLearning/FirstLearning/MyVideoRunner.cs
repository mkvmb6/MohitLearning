using MailService;
using VideoLibrary;

namespace FirstLearning
{
    public class MyVideoRunner
    {
        static void Main()
        {
            var video = new Video();
            var videoCompressor = new VideoCompressor();
            //Subscription
            videoCompressor.VideoCompressed += VideoCompressor_VideoCompressed;
            
            videoCompressor.CompressVideo(video);

        }

        private static void VideoCompressor_VideoCompressed(object source, System.EventArgs e)
        {
            //Doing our work.
            new MailSender().SendMail(new Mail());
        }
    }
}
