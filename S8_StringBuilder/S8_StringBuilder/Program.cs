using System;
using System.Text;

namespace S8_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello world!");

            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);

            builder
                .Replace('-', '+')
                .Remove(0, 10);

            Console.WriteLine(builder);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First charactor: " + builder[0]);
        }
    }
}
