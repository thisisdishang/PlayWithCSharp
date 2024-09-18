// Multidimensional Arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithCSharp
{
    internal class _2DArray
    {
        static void Main(string[] args)
        {
            // The single comma [,] specifies that the array is two-dimensional
            int[,] my2Darray = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Second row first column
            Console.WriteLine(my2Darray[1, 0]);

            my2Darray[1, 1] = 7;
            Console.WriteLine(my2Darray[1, 1]);

            // A three-dimensional array would have two commas: int[,,]
            int[,,] my3Darray = { { { 2, 4, 6 }, { 8, 10, 12 } }, { { 1, 3, 5 }, { 7, 9, 11 } } };

            // Loop through 2D array
            foreach (int i in my2Darray)
            {
                Console.WriteLine(i);
            }

            // Using for loop
            Console.WriteLine("\nDisplay 3D Array:-");
            for (int i = 0; i < my3Darray.GetLength(0); i++)
            {
                for (int j = 0; j < my3Darray.GetLength(1); j++)
                {
                    for (int k = 0; k < my3Darray.GetLength(2); k++)
                    {
                        Console.WriteLine(my3Darray[i, j, k]);
                    }
                }
            }
        }
    }
}