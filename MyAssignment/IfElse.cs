using System;


namespace PlayWithCSharp
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age:");
            int age=Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You're eligible for vote");
            }
            else
            {
                Console.WriteLine("You're not eligible for vote");
            }
        }        
    }
}
