using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    // declaring delegate
    delegate int Calc(int n);

    internal class Delegates
    {
        static int num = 100;

        public static int add(int n) {
            num += n;
            return num;
        }

        public static int mul(int n) { 
            num *= n;
            return num;
        }

        public static int getNumber() { 
            return num;
        }

        static void Main(string[] args) {
            Calc c1=new Calc(add);
            Calc c2=new Calc(mul);
            
            c1(15);
            Console.WriteLine("After C1 delegate, Number is: "+getNumber());
            
            
            c2(3);
            Console.WriteLine("After C2 delegate, Number is: " + getNumber());

            // Multicasting of delegate
            c1 += mul;
            c1.Invoke(5);
            Console.WriteLine("After Multicasting Delegate: " + getNumber());
        }   
    }
}
