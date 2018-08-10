using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{
    public static class MyIntExtension
    {
        public static int MiliSeconds(this int number)
        {
            return number * 1000;
        }
    }
}
