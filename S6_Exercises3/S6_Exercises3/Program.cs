using System;
using System.Collections.Generic;

namespace S6_Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            //When you post a message on Facebook, depending on the number of people who like your post,
            //Facebook displays different information.
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1],
            //[Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names,
            //until the user presses Enter (without supplying a name).
            //Depending on the number of names provided, display a message based on the above pattern.
            Console.WriteLine("Exercise 1");
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                if (name == "")
                    break;
                else
                    names.Add(name);
            }

            var count = names.Count;
            if (count == 1)
                Console.WriteLine(names[0] + " likes your post.");
            else
            {
                if (count == 2)
                    Console.WriteLine(names[0] + " and " + names[1] + " likes your post.");
                else
                {
                    if (count >= 3)
                        Console.WriteLine(names[0] + ", " + names[1] + " and " + (count - 2).ToString() + "others likes your post.");
                }
            }


            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.
            Console.WriteLine("Exercise 2");
            Console.Write("Enter your name: ");
            var yourName = Console.ReadLine();
            var arrName = new char[yourName.Length];
            for (var i = yourName.Length; i > 0; i--)
            {
                arrName[yourName.Length - i] = yourName[i - 1];
            }
            var result = new string(arrName);
            Console.WriteLine("Reversed name: " + result);


            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            Console.WriteLine("Exercise 3");
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter unique number: ");
                var output = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(output))
                {
                    Console.WriteLine("You've previously entered " + output);
                    continue;
                }
                numbers.Add(output);
            }
            numbers.Sort();

            foreach (var n in numbers)
                Console.WriteLine(n);


            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            Console.WriteLine("Exercise 4");
            var num = new List<int>();
            while (num.Count < 5)
            {
                Console.Write("Enter unique number (or \"Quit\" to exit): ");
                var output = Console.ReadLine();
                if (output == "Quit")
                {
                    break;
                }
                else
                {
                    num.Add(Convert.ToInt32(output));
                    continue;
                }
            }
            foreach (var n in num)
                Console.WriteLine(n);


            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List"
            //and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
            Console.WriteLine("Exercise 5");
            var list = "";
            var numb = new List<int>();
            
            Console.Write("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
            list = Console.ReadLine();
                
            
            

        }
    }
}
