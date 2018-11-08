using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProgrammingProblems
{
    internal class StobogrammaticNumber
    {

        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var stobos = new StobogrammaticNumber().FindStrobogrammatic(4);
            stopWatch.Stop();
            foreach (var stobo in stobos)
            {
                Console.WriteLine(stobo+",");
            }
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }

        public IList<string> FindStrobogrammatic(int n)
        {

            #region BadCode

            /*var smallestNumberString = "1";
            var largestNumberString = "9";

            if (n == 1)
            {
                smallestNumberString = "0";
            }
            else
            {
                for (var i = 1; i < n; i++)
                {
                    smallestNumberString += "0";
                    largestNumberString += "9";
                }
            }

            var smallestNumber = Convert.ToInt32(smallestNumberString);
            var largestNumber = Convert.ToInt32(largestNumberString);

            stoboNumbers.AddRange(GetStobosWithInRange(smallestNumber, 2 * smallestNumber));
            stoboNumbers.Add("-------------");
            stoboNumbers.AddRange(GetStobosWithInRange(6 * smallestNumber, 7 * smallestNumber));
            stoboNumbers.Add("-------------");
            stoboNumbers.AddRange(GetStobosWithInRange(8 * smallestNumber, largestNumber));
            stoboNumbers.Add("-------------");*/

            #endregion

            if (n==1)
            {
                return GetOneDigitStobos();
            }
            return MyFindStrobogrammatic(n).Where(dd => !dd.StartsWith("0")).ToList();
        }

        private IList<string> MyFindStrobogrammatic(int n)
        {
            if (n == 1)
            {
                return GetOneDigitStobos();
            }
            if (n == 2)
            {
                return GetTwoDigitStobos();
            }

            var twoDigitStobos = GetTwoDigitStobos();
            var nDigitStobos = new List<string>();
            var nLessTwoStobos = MyFindStrobogrammatic(n - 2);
            foreach (var twoDigitStobo in twoDigitStobos)
            {
                foreach (var nLessTwo in nLessTwoStobos)
                {
                    nDigitStobos.Add(twoDigitStobo[0] + nLessTwo + twoDigitStobo[1]);
                }

            }
            return nDigitStobos;
        }


        private IEnumerable<string> GetStobosWithInRange(int start, int end)
        {
            var stobos = new List<string>();
            for (var i = start; i < end; i++)
            {
                var number = i.ToString();
                if (IsStobogrammatic(number))
                {
                    stobos.Add(number);
                }
            }
            return stobos;
        }

        private int GetStobosWithInRange(string low, string high)
        {
            var digitsInStart = low.Length;
            var digitsInEnd = high.Length;

            var stobos = new List<string>();
            for (var i = digitsInStart; i <= digitsInEnd; i++)
            {
               stobos.AddRange(FindStrobogrammatic(i));
            }
            var startNumber = Convert.ToInt32(low);
            var endNumber = Convert.ToInt32(high);
            var finalValue = stobos.Where(stobo => Convert.ToInt32(stobo) >= startNumber  &&
                                             Convert.ToInt32(stobo) <= endNumber);

            return finalValue.Count();
        }

        private bool IsStobogrammatic(string number)
        {
            var badNumbers = new[] {'2', '3', '4', '5', '7'};
            var tempNum = "";
            var j = 0;
            for (var i = number.Length-1; i >=0 ; i--)
            {
                var c = number[i];
                if (badNumbers.Any(b => b == c))
                {
                    return false;
                }
                switch (c)
                {
                    case '6':
                        tempNum += '9';
                        break;
                    case '9':
                        tempNum += '6';
                        break;
                    default:
                        tempNum += c;
                        break;
                }
                if (tempNum[j]!=number[j])
                {
                    return false;
                }
                j++;
            }
            return true;
        }

        private IList<string> GetOneDigitStobos()
        {
            return new List<string> { "0", "1", "8" };
        }
        private IList<string> GetTwoDigitStobos()
        {
            return new List<string> { "00", "11", "69","88", "96" };
        }
    }
}
