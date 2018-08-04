using System;
using System.Threading;

namespace VideoLibrary
{
    public class VideoCompressor
    {
        //1. Define a delegate.
        //2. Define an event based on the delegate.
        //3. Raise the event (Shout).
        public delegate void VideoCompressedEventHandler(object source, EventArgs e);

        public event VideoCompressedEventHandler VideoCompressed;

        public void CompressVideo(Video video)
        {
            Console.WriteLine("Compressing the video....");
            Thread.Sleep(5000);
            Console.WriteLine("Compression complete.");

            OnVideoCompressed();
        }

        private void OnVideoCompressed()
        {
            //I will just shout.
            //Tell the world, that I'm done. Do your work.
            //if (VideoCompressed != null)
            //{
            //    VideoCompressed(this, EventArgs.Empty);
            //}

            VideoCompressed?.Invoke(this, EventArgs.Empty);
        }
    }
}