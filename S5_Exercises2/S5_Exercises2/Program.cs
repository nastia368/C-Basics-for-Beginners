using System;

namespace S5_Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100
            //are divisible by 3, with no remainder.
            //Display the count on the console.
            Console.WriteLine("Task №1");
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0)
                    count++;
            }
            Console.WriteLine("Count = " + count);


            //2- Write a program and continuously ask the user to enter a
            //number or "ok" to exit. Calculate the sum of all the
            //previously entered numbers and display it on the console.
            Console.WriteLine("\nTask №2");
            int sum = 0;
            string temp = "";
            
            while (true)
            {
                Console.Write("Enter a numer or \"ok\" to exit: ");
                temp = Console.ReadLine();
                if (temp.ToString() == "ok")
                    break;
                else
                    sum += Convert.ToInt32(temp);

                Console.WriteLine("Sum of all the previously entered numbers: " + sum);
            }


            //3 - Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the
            //console. For example, if the user enters 5, the program
            //should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("\nTask №3");
            int factorial = 1;
            int number = 0;

            Console.Write("Enter a numer: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (var i = number; i > 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(number + "! = " + factorial);


            //4- Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number. If the user guesses the number,
            //display “You won"; otherwise, display “You lost". (To make sure the program is
            //behaving correctly, you can display the secret number on the console first.)
            Console.WriteLine("\nTask №4");
            var random = new Random();
            var secret = random.Next(1, 10);
            //Console.Write("The secret number is : " + secret);
            int userNumber = 0;

            for (var i = 4; i >= 1; i--)
            {
                Console.Write("Guess the numer(you have " + i + " chances): ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == secret)
                {
                    Console.WriteLine("\"You won\"!) The secret number is : " + secret);
                    break;
                } 
                else
                    Console.WriteLine("\"You lost\"!(");
            }
            Console.WriteLine("The secret number is : " + secret);


            //5- Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.WriteLine("\nTask №5");
            var numbers = "";
            int max = 0;
            Console.Write("Enter a series of numbers separated by comma (only from 1 to 10): ");
            numbers = Console.ReadLine();

            int bufferLenght = numbers.ToString().Length;
            //Console.WriteLine("bufferLenght = " + bufferLenght);

            for (var i = 0; i < bufferLenght; i++)
            {
                //Console.WriteLine("(char)numbers[i] = " + (char)numbers[i]);
                int tmp = Convert.ToInt32(numbers[i]);
                //Console.WriteLine("tmp = " + tmp);
                if (tmp >= 49 && tmp <= 57)
                {
                    //Console.WriteLine("(char)numbers[i] = " + (char)numbers[i]);
                    if ((char)numbers[i] > max)
                        max = (char)numbers[i] - 48;
                }
            }
            Console.WriteLine("The maximum is: " + max);

        }
    }
}
