using System;

namespace S5_ConditionalStatements
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon!");
            }
            else
            {
                Console.WriteLine("It's evening!");
            }
            

            bool isGoldCustomer = true;
            /*float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f; */

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Spring;
            switch (season)
            {
                case Season.Automn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beatch");
                    break;

                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("We've got a promotion!");
                    break;


                default:
                    Console.WriteLine("I don't understand this season!");
                    break;


            }
        }
    }
}
