// operators in c sharp

using System;

namespace MyAssignment
{
    internal class Operators
    {
       static void Main(string[] args)
        {
            // arithmetic operator
            int sum1 = 100 + 50;
            int sum2 = sum1 + 150;
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            sum3 = sum2 - sum1;
            Console.WriteLine(sum3);

            int num = 5 * 2;
            Console.WriteLine(num);

            float div = 25 / 7;
            Console.WriteLine(div);

            double mod = 26 % 5;
            Console.WriteLine(mod);

            sum3++;
            Console.WriteLine(sum3);
            sum3--;
            Console.WriteLine(sum3);

            // assignment operator
            int no = 7;
            no += 3;
            Console.WriteLine(no);
            no -= 5;
            Console.WriteLine(no);
            no *= 2;
            Console.WriteLine(no);
            no /= 2;
            Console.WriteLine(no);
            no %= 2;
            Console.WriteLine(no);
            no &= 3;
            Console.WriteLine(no);
            no |= 2;
            Console.WriteLine(no);
            no ^= 1;
            Console.WriteLine(no);
            no >>= 2;
            Console.WriteLine(no);
            no <<= 1;
            Console.WriteLine(no);
        }
    }
}
