using System;

namespace NonPrimitiveTypesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
			//string firstName = "Mosh";
			var firstName = "Nastia";
			String lastName = "Peresunko";

			var fullName = firstName + " " + lastName;
			var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
			Console.WriteLine(myFullName);

			var names = new string[3] { "Jack", "John", "Mary" };
			var formattesNames = string.Join(", ", names);
			Console.WriteLine(formattesNames);

			var text = "Hi John\nLook into the following paths\nc:\\folders1\\folder2\nc:\\folders3\\folder4"; // very unreadable
			Console.WriteLine(text);

			var newText = @"Hi John
			Look into the following paths
			c:\folders1\folder2
			c:\folders3\folder4";
			Console.WriteLine(newText);
		}
    }
}
