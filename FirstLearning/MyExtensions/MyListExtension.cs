using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
