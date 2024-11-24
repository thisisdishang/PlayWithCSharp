// Implement Queue in C Sharp

using System;
using System.Collections.Generic;

namespace MyAssignment.Collections
{
    internal class Queue
    {
        static void Main(string[] args)
        {
            Queue<int> number = new Queue<int>();
            number.Enqueue(1);
            number.Enqueue(2);
            number.Enqueue(3);
            number.Enqueue(4);
            number.Enqueue(5);

            foreach (var item in number) { 
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Peek Element: "+number.Peek());
            Console.WriteLine("Dequeue: "+number.Dequeue());
            Console.WriteLine("After dequeue, Peek Element: " + number.Peek());
        }
    }
}
