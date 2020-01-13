using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Nastia";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            //Type Conversion
            byte b = 1;
            int i = b; //without date loss
            Console.WriteLine(i);

            int a = 1;
            byte c = (byte)a;
            Console.WriteLine(a);
            Console.WriteLine(c);
            int d = 1000;
            byte e = (byte)d;
            Console.WriteLine(d);
            Console.WriteLine(e);

            var numberTwo = "1234";
            int j = Convert.ToInt32(numberTwo);
            Console.WriteLine("J = " + j);

            try
            {
                byte f = Convert.ToByte(numberTwo);
                Console.WriteLine(f);
            }
            catch (Exception ex)
            {
                Console.WriteLine("crash");
            }

            try
            {
                string str = "true";
                bool g = Convert.ToBoolean(str);
                Console.WriteLine(g);
            }
            catch (Exception ex)
            {
                Console.WriteLine("crash 2 ");
            }
        }
    }
}
