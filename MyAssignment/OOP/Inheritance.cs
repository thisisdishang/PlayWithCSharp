// Inheritance in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    sealed class Engine
    {
        // this class can not inherited
    }

    class Vehicle
    {
        public string brand = "Ford";

        public void honk()
        {
            Console.WriteLine("Tuut tuut!");
        }
    }

    class Newcar : Vehicle
    {
        public string modelname = "mustang";
    }

    class driver
    {
        static void Main(string[] args)
        {
            Newcar ob1 = new Newcar();
            ob1.honk();
            Console.WriteLine(ob1.brand + " " + ob1.modelname);
        }
    }
}
