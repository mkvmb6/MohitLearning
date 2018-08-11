using System.Collections.Generic;

namespace MyExtensions
{
    public static class MyListExtension
    {
        public static T MyFirst<T>(this List<T> list)
        {
            return list[0];
        }
    }
}
