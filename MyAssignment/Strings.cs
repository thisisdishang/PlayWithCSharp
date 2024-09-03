// strings in c sharp

using System;

namespace PlayWithCSharp
{
    internal class Strings
    {
        static void Main(string[] args)
        {
            string ambition = "I'm the founder";
            Console.WriteLine("Lenght of the string: "+ ambition.Length);
            Console.WriteLine("Upper case: " + ambition.ToUpper());
            Console.WriteLine("Lower case: "+ ambition.ToLower());

            // string concatenation
            string firstname = "James ";
            string lastname = "Bond ";
            string name=string.Concat(firstname, lastname);
            Console.WriteLine(name);

            // string interpolation
            Console.WriteLine($"Name: {firstname}, Surname: {lastname}");
            
            // access strings
            Console.WriteLine(name[3]);
            Console.WriteLine(name.IndexOf("B"));
            string subname = name.Substring(6);
            Console.WriteLine(subname);

            // special characters
            Console.WriteLine("This is \"special\"");
            Console.WriteLine("Hello \'One\'");
            Console.WriteLine("Namaste \n From Bharat \tIndia");





        }
    }
}
