﻿// Func Delegates in C Sharp

using System;

namespace MyAssignment
{

    internal class FuncDelegate
    {
        public static int FuncMethod(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static void Main(string[] arg)
        {
            Func<int, int, int, int, int> fd = FuncMethod;
            Console.WriteLine("Func Delegate: " + fd(4, 2, 3, 10));
        }
    }
}
