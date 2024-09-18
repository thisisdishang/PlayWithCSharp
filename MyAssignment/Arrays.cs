// Arrays in C Sharp

namespace PlayWithCSharp
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            string[] names = { "Alpha","Beta","Gama","Delta"};
         
            // access the elements of an array
            Console.WriteLine(names[2]);

            // change an array element
            names[2] = "Ela";
            Console.WriteLine(names[2]);

            // array length
            Console.WriteLine(names.Length);

            // other ways to create an array
            string[] car;
            car= new string[] {"Volvo","BMW","Ford"};

            // loop through an array
            for(int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            
            // add element in existing array
            car=car.Append("Mercedes").ToArray();
            car = car.Concat(["Audi", "Ferrari"]).ToArray();
            
            // foreach loop
            foreach (string item in car)
            {
                Console.WriteLine(item);
            }

            // sort string array
            Array.Sort(car);
            
            Console.WriteLine("\nSorted Array:-");
            
            foreach(string item in car)
            {
                Console.WriteLine(item);
            }

            int[] no = {89,12,0,63,4,9,3,1,10 };

            // sort int array
            Array.Sort(no);

            foreach (var item in no)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Maximum Number: "+no.Max());
            Console.WriteLine("Minimum Number: " + no.Min());
            Console.WriteLine("Sum of Element: " + no.Sum());
        }
    }
}
