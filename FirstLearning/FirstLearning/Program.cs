using System;

namespace FirstLearning
{
    //Declaration of delegate
    //<Access> delegate <ReturnType> <DelegateName> (<params> );
    public delegate void MyDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            //myClass.MyNotSoStaticMethod(4);


            //Instantiation of delegate
            var delObj = new MyDelegate(MyClass.MyMethod);

            //Adding methods into it.
            delObj += myClass.MyNotSoStaticMethod;
            delObj += myClass.MyNotSoStaticMethod;

            //Removing
            delObj -= MyClass.MyMethod;

            //Invoking
            delObj(5);

        }

    }


    class MyClass
    {
        public int y = 10;

        public static void MyMethod(int a)
        {
            Console.WriteLine("MyMethod got called.. with " + a);
        }

        public void MyNotSoStaticMethod(int y)
        {
            Console.WriteLine("MyNotSoStaticMethod got called... with" + y);
        }
    }
}
