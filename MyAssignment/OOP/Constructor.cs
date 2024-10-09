// Constructor in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    internal class Car2
    {
        public string model;  // Create a field
        public string modelcolor;

        // Create a class constructor for the Car class
        public Car2()
        {
            model = "Mustang"; // Set the initial value for model
        }

        // parameterize constructor
        public Car2(string modelcolor)
        {
            this.modelcolor = modelcolor;
        }

        static void Main(string[] args)
        {
            Car2 Ford = new Car2();  // Create an object of the Car Class (this will call the constructor)
            Car2 BMW = new Car2("white");
            Console.WriteLine(BMW.modelcolor);
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }
}
