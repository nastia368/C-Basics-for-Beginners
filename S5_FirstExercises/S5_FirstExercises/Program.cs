using System;

namespace S5_FirstExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Exercise
            int number = 0;
            Console.WriteLine("Enter a numer between 1 to 10:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");


            //Second Exercise
            Console.WriteLine("Enter two numers:");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            int max = (first > second) ? first : second;
            Console.WriteLine("Maximum is " + max);


            //Third Exercise
            Console.WriteLine("Enter width:");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height:");
            var height = Convert.ToInt32(Console.ReadLine());

            var result = (width > height) ? Orientation.Landscape : Orientation.Portrait;
            Console.WriteLine("Image orientation is " + result);


            //Fouth Exercise
            Console.WriteLine("Enter speed limit:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed of the car:");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            int points = 0;
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK!");
            }
            else
            {
                points = (carSpeed - speedLimit) / 5;
                if (points >= 12)
                    Console.WriteLine("License Suspended!");
                else
                    Console.WriteLine("The number of demerit points is " + points);
            }
        }
        public enum Orientation
        {
            Landscape,
            Portrait
        }
    }
}
