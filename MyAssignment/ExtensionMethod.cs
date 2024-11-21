// Extension method in C Sharp

using System;

namespace MyAssignment
{
    class ExtensionMethod
    {
        public void method1()
        {
            Console.WriteLine("Method 1");
        }
        public void method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    static class AnotherMethod
    {
        public static void method3(this ExtensionMethod e)
        {
            Console.WriteLine("Method 3");
        }
    }

    class Extension
    {
        static void Main(string[] args)
        {
            ExtensionMethod e = new ExtensionMethod();
            e.method1();
            e.method2();
            e.method3();
        }
    }
}
