using System;

namespace S5_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            Console.Write("\nAnother code: ");
            Console.WriteLine((int)'a');

            Console.Write("\nAnother code: ");
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));
            }

            Console.Write("\nAnother code: ");
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0, 26)));
            }

            Console.Write("\nAnother code: ");
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.Write(password);
        }
    }
}
