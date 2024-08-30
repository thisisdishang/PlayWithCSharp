// variables in c sharp

using System;

namespace PlayWithCSharp
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            int a = 50;
            Console.WriteLine(a);

            // note that if you assign a new value to an existing variable, it will overwrite the previous value
            a = 75;
            Console.WriteLine(a);

            string name = "Lucifer";
            Console.WriteLine("Hello "+name);

            char letter= 'D';
            Console.WriteLine(letter);

            double e = 7.2D;
            Console.WriteLine(e);

            bool result= true;
            Console.WriteLine(result);

            // constant variable
            const double PI = 3.14D;
            Console.WriteLine(PI);

            // add two variable to another variable
            string firstName = "Tony ";
            string lastName = "Stark ";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 10;
            int y = 14;
            Console.WriteLine(x+y);

            // declare many variables
            int p = 15, q = 20, r = 25;
            Console.WriteLine(p+q+r);

            int s, t, u;
            s = t = u = 7;
            Console.WriteLine(s+t+u);

        }
    }
}
