using System;
using System.Collections.Generic;

namespace S6_List
{
    class Program
    {
        static void Main(string[] args)
        {
			var numbers = new List<int>() { 1, 2, 3, 4 };
			numbers.Add(1);
			numbers.AddRange(new int[3] { 5, 6, 7 });
			foreach (var n in numbers)
				Console.WriteLine(n);

			//IndexOf
			Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); //0

			//LastIndexOf
			Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1)); //4

			//Count()
			Console.WriteLine("Count: " + numbers.Count);

			//Remove()
			//numbers.Remove(1);
			for (var i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == 1)
					numbers.Remove(numbers[i]);
			}
			foreach (var number in numbers)
				Console.WriteLine(number);

			//Clear()
			numbers.Clear();
			Console.WriteLine("Count: " + numbers.Count);

		}
	}
}
