// Access properties from another class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    internal class Second
    {
        static void Main(string[] args)
        {
            Car ob1 = new Car();
            Console.WriteLine(ob1.color);
        }
    }
}
