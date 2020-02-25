using System;
using System.Collections.Generic;

namespace S8_Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately;
            //otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            Console.WriteLine("Exercise 2");
            while(true)
            {

                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;

                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                    numbers.Add(Convert.ToInt32(number));

                var flag = false;
                var unique = new List<int>();
                foreach (var number in numbers)
                {
                    if (unique.Contains(number))
                    {
                        flag = true;
                    }
                    else
                    {
                        unique.Add(number);
                    }
                }

                if (flag)
                    Console.WriteLine("Duplicate");

                foreach (var number in unique)
                    Console.WriteLine(number + ", ");



            }
        }
    }
}
