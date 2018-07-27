using System;

namespace PhotoLibrary
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness applied.");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast applied.");
        }
    }
}
