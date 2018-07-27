using PhotoLibrary;

namespace FirstLearning
{
    class MyPhotoRunner
    {
        static void Main(string[] args)
        {
            var photo = Photo.LoadPhoto("C:\\photos\\Mypic.jpg");
            PhotoProcessor.ProcessPhoto(photo);
        }
    }
}
