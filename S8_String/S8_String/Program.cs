using System;

namespace S8_String
{
    class Program
    {
        static void Main(string[] args)
        {
			var fullName = "Anastasiia Peresunko ";
			Console.WriteLine("Trim: '{0}'", fullName.Trim());  //'Anastasiia Peresunko'
			Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());  //'ANASTASIIA PERESUNKO'

			//split first name and last name
			var index = fullName.IndexOf(' ');
			var firstName = fullName.Substring(0, index);
			var lastName = fullName.Substring(index + 1);
			Console.WriteLine("First name: " + firstName);
			Console.WriteLine("Last name: " + lastName);

			var names = fullName.Split(' ');
			Console.WriteLine("First name: " + names[0]);
			Console.WriteLine("Last name: " + names[1]);


			//Replase
			Console.WriteLine(fullName.Replace("Anastasiia", "Nastia"));


			//Trim()
			if (String.IsNullOrEmpty(" ".Trim()))
				Console.WriteLine("Invalid");

			if (String.IsNullOrWhiteSpace(" "))
				Console.WriteLine("Invalid");


			//Convert
			var str = "25";
			var age = Convert.ToByte(str);
			Console.WriteLine(age);

			float price = 29.95f;
			Console.WriteLine(price.ToString("C"));
			Console.WriteLine(price.ToString("C0"));
		}
    }
}
