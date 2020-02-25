using System;

namespace S6_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Lenght
            Console.WriteLine("Lenght: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("IndexOf(9): " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear(): ");
            foreach (var n in numbers)
                Console.WriteLine(n);
         
            //Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy(): ");
            foreach (var a in another)
                Console.WriteLine(a);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort(): ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Revers()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse(): ");
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
