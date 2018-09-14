using System;

namespace FirstLearning
{
    public class UseLamdaExpression
    {
        public int GetSquare(int num)
        {
            return num * num;
        }
    }

    public class LambdaExpressionRunner
    {
        static void Main(string[] args)
        {
            //num=>num*num

            //var useLambda = new UseLamdaExpression();
            //var num = 5;
            //var square = useLambda.GetSquare(num);
            //Console.WriteLine(square);



            var useLambda = new UseLamdaExpression();
            const int num = 5;
            //Console.WriteLine(new Func<int, int>(useLambda.GetSquare));
            var func = new Func<int, int>((arg) => arg * arg);
            Console.WriteLine(func(num));
        }
    }
}
