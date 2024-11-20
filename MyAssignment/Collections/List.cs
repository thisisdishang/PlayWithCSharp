// List in C Sharp

using System;
using System.Collections.Generic;


namespace MyAssignment.Collections
{
    internal class List
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
