// LinkedList in C Sharp

using System;
using System.Collections.Generic;

namespace MyAssignment.Collections
{
    internal class LinkedList
    {
        static void Main(string[] args)
        {
            var city = new LinkedList<string>();
            city.AddFirst("Surat");
            city.AddFirst("Vadodara");
            city.AddLast("Ahmedabad");

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
        }
    }
}
