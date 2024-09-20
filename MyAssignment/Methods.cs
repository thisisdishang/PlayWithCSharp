// Methods in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithCSharp
{
    class Methods
    {
        // create a method
        static void MyMethod()
        {
            Console.WriteLine("Method is call");
        }

        // method parameter
        static void MyMethod2(string name, string role)
        {
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Your role is " + role);
        }

        // default parameter
        static int square(int num = 0)
        {
            return num * num;
        }

        // return values
        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // named arguments
        static void MyMethod3(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        // method overloading
        static int Plus(int x, int y)
        {
            return x + y;
        }

        static double Plus(double x, double y)
        {
            return x + y;
        }




        static void Main(string[] args)
        {
            // call a method
            MyMethod();
            MyMethod2("Lucy", "Student");
            Console.WriteLine("Squre of number: " + square(5));
            Console.WriteLine("Squre of number: " + square());
            Console.WriteLine("Sum of two numbers: " + sum(5, 2));
            MyMethod3(child3: "Amy", child1: "Lais", child2: "Reya");

            // call overload method
            Console.WriteLine("Int Method: " + Plus(5, 2));
            Console.WriteLine("Double Method: " + Plus(5.5D, 2.3D));
        }
    }
}
