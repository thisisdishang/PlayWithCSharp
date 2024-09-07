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

            Console.WriteLine("Enter the number:");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num == 0) {
                Console.WriteLine("Number is zero");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            // short hand if..else
            int time = 20;
            string display = (time < 18) ? "Good day" : "Good evening";
            Console.WriteLine(display);
        }        
    }
}
