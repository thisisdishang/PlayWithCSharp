// Dictionary in C Sharp

using System;
using System.Collections.Generic;

namespace MyAssignment.Collections
{
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> student = new Dictionary<int,string>();
            student.Add(201, "Lucifer");
            student.Add(202, "Peter");
            student.Add(203, "Kratos");
            student.Add(204, "Genesis");

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
        }
    }
}
