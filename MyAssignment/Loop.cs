using System;


namespace PlayWithCSharp
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            // while loop
            int i = 0;
            while (i < 5) {
                Console.WriteLine(i);
                i++ ;
            }

            Console.WriteLine("\n");
            // do while loop
            int j=0;
            do
            {
                j++;
                Console.WriteLine(j);               
            } while (j < 5);

            Console.WriteLine("\n");
            // for loop
            for (int k = 0; k <= 10; k+=2)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("\n");
            // for each loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string l in cars)
            {
                Console.WriteLine(l);
            }
        }
    }
}
