// Enums in C Sharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    enum Level
    {
        Easy,
        Medium,
        Hard,
        Legend
    }

    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August
    }

    class Enums
    {
        static void Main(string[] args)
        {
            var num = (int)Months.April;
            Console.WriteLine(num);
            Console.WriteLine(Level.Legend);
        }
    }
}
