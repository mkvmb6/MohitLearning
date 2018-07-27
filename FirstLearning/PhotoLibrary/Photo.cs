using System;

namespace PhotoLibrary
{
    public class Photo
    {
        public static Photo LoadPhoto(string filePath)
        {
            Console.WriteLine("Photo instance created.");
            return new Photo();
        }
    }
}
