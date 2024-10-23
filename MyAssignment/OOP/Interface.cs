ni﻿// Interface in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment.OOP
{
    interface Bank
    {
        void interest();
    }

    interface SecondInterface
    {
        void method();
    }

    class Kotak : Bank, SecondInterface
    {
        public void interest()
        {
            Console.WriteLine("SBI Interest:8%");
        }

        public void method()
        {
            Console.WriteLine("Method is call");
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {
            Kotak s1 = new Kotak();
            s1.interest();
            s1.method();
        }
    }
}
