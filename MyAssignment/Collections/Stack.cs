// Stack collection in C Sharp

using System;
using System.Collections.Generic;

namespace MyAssignment.Collections
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> city = new Stack<string>();
            city.Push("Surat");
            city.Push("Vadodara");
            city.Push("Ahmedabad");

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Peek Element: " + city.Peek());
            Console.WriteLine("Pop Element: " + city.Pop());
            Console.WriteLine("After pop, Peek Element: " + city.Peek());
        }
    }
}
