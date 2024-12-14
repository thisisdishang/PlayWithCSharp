// Jagged Arrays in C Sharp

using System;
using System.Collections.Generic;

namespace PlayWithCSharp
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[] { 7, 8, 9 };
            arr[1] = new int[] { 78, 96, 12, 32 };

           Console.WriteLine("Array 1:-");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nArray 2:-");
            int[][] arr2 = new int[3][]{
                new int[] { 11, 21, 56, 78 },
                new int[] { 2, 5, 6, 7, 98, 5 },
                new int[] {7,9 }
            };

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
