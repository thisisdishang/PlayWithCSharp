// Polymorphism in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{

    class RBI
    {
        public virtual void rate()
        {
            Console.WriteLine("Rate Interest in RBI 8%");
        }
    }

    class SBI : RBI
    {
        public override void rate()
        {
            Console.WriteLine("Rate Interest in SBI 10%");
        }
    }

    class HDFC : RBI
    {
        public override void rate()
        {
            Console.WriteLine("Rate Interest in HDFC 12%");
        }
    }

    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            RBI o1 = new RBI();
            RBI o2 = new SBI();
            RBI o3 = new HDFC();

            o1.rate();
            o2.rate();
            o3.rate();
        }
    }
}
