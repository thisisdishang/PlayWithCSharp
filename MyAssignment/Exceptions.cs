using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    internal class Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                Console.WriteLine(numbers[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("finally block is executed");
            }
        }
    }
}
