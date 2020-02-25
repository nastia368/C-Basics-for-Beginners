using System;

namespace S7_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
			var timeSpan = new TimeSpan(1, 2, 3);
			var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

			var start = DateTime.Now;
			var end = DateTime.Now.AddMinutes(2);
			var duration = end - start;  //2 minutes
			Console.WriteLine("Duration: " + duration);

			//Properties
			Console.WriteLine("Minutes: " + timeSpan.Minutes); //2
			Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); //62.05

			//Add
			Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); //01:10:03
			Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8))); //01:00:03

			//ToString
			Console.WriteLine("ToString: " + timeSpan.ToString());

			//Parse
			Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
		}
    }
}
