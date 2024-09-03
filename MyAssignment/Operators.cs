// operators in c sharp

using System;

namespace PlayWithCSharp
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

            // comparison operator
            int x = 5,y=3;
            Console.WriteLine(x>y);
            x=3; y=2;
            Console.WriteLine(x<y);
            Console.WriteLine(x==y);
            Console.WriteLine(x!=y);
            x = 3; y=3;
            Console.WriteLine(x>=y);
            Console.WriteLine(x<=y);

            // logical operator
            Console.WriteLine(5<10 && 5<4);
            Console.WriteLine(2>0 || 3<2);
            Console.WriteLine(!(2 > 0 || 3 < 2));

            // math class methods
            Console.WriteLine(Math.Max(50, 20));
            Console.WriteLine(Math.Min(50, 20));
            Console.WriteLine(Math.Abs(-3.25));
            Console.WriteLine(Math.Sqrt(121));
            Console.WriteLine(Math.Round(5.6));
            Console.WriteLine(Math.Round(5.4));

        }
    }
}
