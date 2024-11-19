// Action Delegates in C Sharp

using System;

namespace MyAssignment
{
    internal class ActionDelegate
    {
        public static void mysum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            Action<int, int> ad = mysum;
            ad(5, 2);

            Action<string> ad2 = delegate (string s) { Console.WriteLine(s); };
            ad2("Just Bring It!");
        }

    }
}
