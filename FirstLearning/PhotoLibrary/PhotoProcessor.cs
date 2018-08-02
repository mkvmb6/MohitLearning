using System;
using System.Collections.Generic;

namespace PhotoLibrary
{
    public class PhotoProcessor
    {
        //public delegate void PhotoHandler(Photo photo);
        public static void ProcessPhoto(Photo photo, Action<Photo> photoHandler)
        {
            //var photoFilters = new PhotoFilters();
            //photoFilters.ApplyBrightness(photo);
            //photoFilters.ApplyContrast(photo);
            
            photoHandler(photo);
            
        }
    }

    //Action <--- Void type
    //Func <---Return one object

    
}
