// Generics in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{

    // Generic Class
    class GenericsClass<T>
    {
        public GenericsClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    class NonGenericsClass
    {
        // Generic Method
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    internal class Generics
    {
        static void Main(string[] args)
        {
            GenericsClass<string> gen = new GenericsClass<string>("Legend Never Dies");
            GenericsClass<int> gen2 = new GenericsClass<int>(7);
            GenericsClass<char> gen3 = new GenericsClass<char>('D');
            NonGenericsClass nonGenericsClass = new NonGenericsClass();
            nonGenericsClass.Show("This is generic method");
            nonGenericsClass.Show(101);
        }
    }
}
