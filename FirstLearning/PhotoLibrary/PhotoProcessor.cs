namespace PhotoLibrary
{
    public class PhotoProcessor
    {
        public static void ProcessPhoto(Photo photo)
        {
            var photoFilters = new PhotoFilters();
            photoFilters.ApplyBrightness(photo);
            photoFilters.ApplyContrast(photo);
        }
    }
}
