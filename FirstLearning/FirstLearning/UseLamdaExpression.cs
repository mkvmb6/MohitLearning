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
            Console.WriteLine(new Func<int, int>(useLambda.GetSquare));
            Console.WriteLine(new Func<int>(() => num * num));
            TestCase(() =>
            {
                Console.WriteLine(num);
                Console.WriteLine("testcase ");
                Console.WriteLine("cw 2");
            });


        }

        public static void TestCase(Action action)
        {
            Console.WriteLine("Start");
            action();
        }
    }
}
