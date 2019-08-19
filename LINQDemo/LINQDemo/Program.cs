using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Array
			var myArray = new int[3];
			myArray[0] = 0;
			myArray[1] = 1;
			myArray[2] = 2;

			var convertedList = myArray.ToList();
			convertedList.Add(3);
			// List
			var myList = new List<int>();
			myList.Add(0);
			var convertedArray = myList.ToArray();

			// Dictionary
			var myDictionary = new Dictionary<int, string>();
			myDictionary.Add(1000, "Hello World");
			myDictionary.Add(3000, "This is a string");

			//if (myDictionary.ContainsKey(1000)) Console.WriteLine(myDictionary[1000]);


			// LINQ = Language Integrated Query
			// is an integral part of C#

			var intArray = new int[]{ -100, 50, 2, 3, 4, 1000, 1000 };
			PrintArray(intArray);

			// Lambda expression?
			// (parameters) => output
			// x => x*x 
			// (x,y,z) => x + y + z

			// Where()
			var filteredArray = intArray.Where(z => z < 0).ToArray();
			PrintArray(filteredArray);

			// Get only even numbers?
			var evenNumbers = intArray.Where(z => z % 2 == 0).ToArray();
			PrintArray(evenNumbers);

			// SELECT
			var people = new List<Person>();
			people.Add(new Person
			{
				FirstName = "Ray",
				LastName = "Nham",
				Age = 25,
				Emails = new string[] { "ray@gmail.com", "ray2@email.com" }
			});
			people.Add(new Person
			{
				FirstName = "Robin",
				LastName = "Lavis",
				Age = 20,
				Emails = new string[] { "rob@gmail.com", "rob2@email.com" }
			});
			people.Add(new Person
			{
				FirstName = "John",
				LastName = "Doe",
				Age = 20,
				Emails = new string[] {"john@gmail.com", "john2@email.com"}
			});
			people.Add(new Person
			{
				FirstName = "Jane",
				LastName = "Alek",
				Age = 30,
				Emails = new string[] { "jane@gmail.com", "jane2@email.com" }
			});
			

			


			var lastNames = people.Select(z => z.LastName).ToArray();
			var fullNames = people.Select(z => $"{z.FirstName} {z.LastName}").ToArray();

			var firstAndLastNames = people.Select(z => new
			{
				FirstName = z.FirstName,
				LastName = z.LastName
			}).ToArray();


			var peopleOlderThan25 = people.Where(z => z.Age > 25).ToArray();

			// Get the first name of all people who are younger than 25 years old.
			//var firstNameYoungerThan25 = ??

			var firstNameYoungerThan25 = people.Where(z => z.Age < 25).Select(z => z.FirstName).ToArray();
			// var firstNameYoungerThan25 = people.Select(x => x.FirstName).Where(z => z.Age < 25).toArray();
			// var fNameYoungerthan25 = people.Where(z => z < 25).Select(z => z.FirstName);
			// var firstNameYoungerThan25 = people.Select(z => $"{z.FirstName}").Where(z => z.Age < 25)
			// var firstNameYoungerThan25 = people.Select(z => z.FirstName).Where(z=>z.Age<25).ToArray();
			// var firstNameYoungerThan25 = people.Select(z => z.FirstName).Where(z => z.Age < 25).ToArray();

			// Get all the first names that contains the letter "R"
			var firstNameContainsR = people.Select(z => z.FirstName).Where(z => z.Contains("R"));

			// SELECTMANY
			//people.Add(new Person
			//{
			//	FirstName = "Robin",
			//	LastName = "Lavis",
			//	Age = 20,
			//	Emails = new string[] { "rob@gmail.com", "rob2@email.com" }
			//});
			var emailsOfEachPerson = people.Select(z => z.Emails).ToList();
			// What is the datatype of emailsOfEachPerson? 
			// - Array of strings - Wrong
			// - List of people - Wrong
			// - List of list of people - Wrong
			// - List of string[] - Correct

			// Select many
			var emailsOfEachPerson2 = people.SelectMany(z => z.Emails).ToList();
			// List of string


			// Aggragate LINQ queries
			// Min, Max, Average, Sum, Count, Distinct
			var minInt = intArray.Min();
			var distinctInt = intArray.Distinct();

			// First(), Last(), Single()
			// FirstOrDefault(), LastOrDefault(), SingleOrDefault()

			// Get all the first names that contains the letter "R"
			var firstName = people
				.Where(z => z.Age > 30)
				.Select(z => z.FirstName)
				.LastOrDefault();

			// null

			// Take(), TakeWhile(), Skip(), SkipWhile()
			var first2FirstNames = people.Select(z => z.FirstName).Take(2);
			var result = people.Select(z => z.FirstName).TakeWhile(z => z.Contains("R"));

			var skip2FirstNames = people.Select(z => z.FirstName).Skip(2);
			var result2 = people.Select(z => z.FirstName).SkipWhile(z => z.Contains("R"));



			Console.ReadLine();
		}


		private static void PrintArray(int[] array)
		{
			foreach (var item in array)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}
	}
}
