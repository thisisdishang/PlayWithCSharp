// Class and Object in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    class Car
    {
        public string color = "Red"; // field

        static void Main(string[] args)
        {
            Car ob1 = new Car();
            Console.WriteLine(ob1.color);
        }
    }
}
