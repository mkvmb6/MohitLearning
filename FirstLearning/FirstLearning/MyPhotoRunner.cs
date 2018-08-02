using System;
using PhotoLibrary;

namespace FirstLearning
{
    class MyPhotoRunner
    {
        static void Main(string[] args)
        {
            var photo = Photo.LoadPhoto("C:\\photos\\Mypic.jpg");
            //PhotoProcessor.PhotoHandler photoHandler = PhotoFilters.ApplyBrightness;

           // photoHandler += PhotoFilters.ApplyContrast;

            Action<Photo> photoHandler = PhotoFilters.ApplyBrightness;
            photoHandler += PhotoFilters.ApplyContrast;

            PhotoProcessor.ProcessPhoto(photo, photoHandler);


            var photo2 = Photo.LoadPhoto("MyPic");

            photoHandler -= PhotoFilters.ApplyContrast;
            photoHandler += MyOwnFilters.MakeBlackAndWhite;

            PhotoProcessor.ProcessPhoto(photo2, photoHandler);






        }
    }
}
