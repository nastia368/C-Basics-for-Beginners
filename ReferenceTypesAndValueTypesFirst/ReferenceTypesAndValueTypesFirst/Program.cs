using System;

namespace ReferenceTypesAndValueTypesFirst
{
    class Program
    {
        static void Main(string[] args)
        {
			var a = 10; //integer
			var b = a;
			b++;
			Console.WriteLine(string.Format("Value of a = {0}, value of b = {1}", a, b)); //a=10 b=11
																						  //result: values are copied
			var array1 = new int[3] { 1, 2, 3 };
			var array2 = array1;
			array2[0] = 0;
			Console.WriteLine(string.Format("array1[0]: {0}; array2[0]: {1}", array1[0], array2[0]));
		}
    }
}
