namespace PhotoLibrary
{
    public class PhotoProcessor
    {
        public delegate void PhotoHandler(Photo photo);
        public static void ProcessPhoto(Photo photo, PhotoHandler photoHandler)
        {
            //var photoFilters = new PhotoFilters();
            //photoFilters.ApplyBrightness(photo);
            //photoFilters.ApplyContrast(photo);
            
            photoHandler(photo);
        }
    }
}
