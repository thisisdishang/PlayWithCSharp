// Arrays in C Sharp

namespace PlayWithCSharp
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            string[] names = { "Alpha","Beta","Gama","Delta"};
            int[] no= {1,2,3,4,5,6,7,8,9,10};

            foreach (var item in no)
            {
                Console.WriteLine(item);
            }


            // access the elements of an array
            Console.WriteLine(names[2]);
            names[2] = "Ela";
            Console.WriteLine(names[2]);

            // array length
            Console.WriteLine(names.Length);

            // other ways to create an array
            string[] car;
            car= new string[] {"Volvo","BMW","Ford"};
        }
    }
}
