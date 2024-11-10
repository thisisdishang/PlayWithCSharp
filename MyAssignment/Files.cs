// Files in C Sharp

using System.IO;

namespace MyAssignment
{
    internal class Files
    {
        static void Main(string[] args)
        {
            string writeText = "Never Settle";
            File.WriteAllText("myfile.txt", writeText);

            string appendText = "For Less";
            File.AppendAllText("myfile.txt", appendText);

            string readText = File.ReadAllText("myfile.txt");
            Console.WriteLine(readText);

        }
    }
}
