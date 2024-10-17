// Abstraction in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    abstract class Shape
    {
        public abstract void area();
        public virtual void color()
        {
            Console.WriteLine("Red");
        }
    }

    class circle : Shape
    {
        public override void area()
        {
            Console.WriteLine("PI*r*r");
        }

        public override void color()
        {
            Console.WriteLine("Blue");
        }

    }


    class Abstraction
    {
        static void Main(string[] args)
        {
            circle ob1 = new circle();
            ob1.area();
            ob1.color();
        }
    }
}
