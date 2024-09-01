/* type casting in c sharp */

using System;

namespace PlayWithCSharp
{
    internal class TypeCasting
    {
        static void Main(string[] args)
        {
            // implicit casting
            int myInt = 5;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // explicit casting
            double myDouble2 = 9.88D;
            int myInt2 =(int)myDouble2;
            Console.WriteLine(myInt2);

            // type conversion methods
            bool myBool = false;
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToInt32(myDouble2));
            Console.WriteLine(Convert.ToDouble(myInt));
        }
    }
}
