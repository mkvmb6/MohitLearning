using System;
using System.Threading;

namespace VideoLibrary
{
    public class VideoCompressor
    {
        //1. Define a delegate.
        //2. Define an event based on the delegate.
        //3. Raise the event (Shout).
       // public delegate void VideoCompressedEventHandler(object source, VideoEventArgs e);        

        public event EventHandler<VideoEventArgs> VideoCompressed;

        public void CompressVideo(Video video)
        {
            Console.WriteLine("Compressing the video....");
            Thread.Sleep(5000);
            Console.WriteLine("Compression complete.");

            OnVideoCompressed(video);
        }

        private void OnVideoCompressed(Video video )
        {
            //I will just shout.
            //Tell the world, that I'm done. Do your work.
            //if (VideoCompressed != null)
            //{
            //    VideoCompressed(this, EventArgs.Empty);
            //}

            VideoEventArgs  e = new VideoEventArgs ();
            e.Video = video;
            
            VideoCompressed?.Invoke(this,e);
        }
    }

   public  class VideoEventArgs:EventArgs
    {
        public Video Video { get; set; }
    }
}