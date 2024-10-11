// Properties in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    class Person
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public int no { get; set; }
    }
    internal class GetSet
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Demon";
            Console.WriteLine(person.Name);
            person.no = 7;
            Console.WriteLine(person.no);
        }
    }

}