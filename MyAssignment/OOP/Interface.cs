// Interface in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    interface Bank
    {
        void interest();
    }

    class Kotak : Bank
    {
        public void interest()
        {
            Console.WriteLine("SBI Interest:8%");
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {
            Kotak s1 = new Kotak();
            s1.interest();
        }
    }
}
