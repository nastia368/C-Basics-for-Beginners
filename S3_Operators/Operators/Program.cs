using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);

            var c = 1;
            var d = 2;
            var e = 3;

            Console.WriteLine(c + d * e);

            Console.WriteLine(c > d);

            Console.WriteLine(c != d);

            Console.WriteLine(e > d && e == c);
            Console.WriteLine(e > d || e == c);
        }
    }
}
