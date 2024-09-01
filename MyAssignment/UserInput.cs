// user input in c sharp

using System;


namespace PlayWithCSharp
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string username=Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome "+username+" Your age is "+age);
        }
    }
}
