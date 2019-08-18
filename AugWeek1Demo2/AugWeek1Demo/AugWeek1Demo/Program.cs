using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugWeek1Demo
{
	class Program
	{
		public int AnInt { get; set; } // Will be discussed when explaining Classes
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			// Naming Conventions
			// Pascal Cases: Method names, class names, interface names, class variables etc.
			// Camel Cases: for local variable names, method's parameter names.

			// Value Types (Primitive types): int, bool, char, float, double, etc.
			// var keyword 
			int myInt;
			myInt = 5;

			var myVarInt = 5;

			// Reference Types: string, objects, arrays, collections, etc.
			// Value vs Ref Types: http://www.albahari.com/valuevsreftypes.aspx
			string myString = "";
			var myVarString = "";

			int[] intArray = new int[] { 0, 1, 2, 3 };
			//Console.WriteLine($"First String = {intArray[0]}"); 

			// Loops
			// for loop
			for(var i = 0; i < intArray.Length; i++)
			{
				//Console.WriteLine(intArray[i]);
			}
			// foreach
			foreach(var n in intArray)
			{
				//Console.WriteLine(number);
			}

			// while
			var index = 0;
			//while(index < intArray.Length)
			//{
			//	//Console.WriteLine(intArray[index++]);
			//	//index++; // index = index + 1
			//}

			// do-while
			var index1 = 0;
			//do
			//{
			//	//Console.WriteLine(intArray[index1++]);
			//} while (index1 < intArray.Length);

			// Conditional statements: if, if-else, switch
			// if
			//if ()
			//{

			//}

			// if-else
			//if ()
			//{

			//}
			//else
			//{

			//}

			// switch
			var number = 3;
			switch(number)
			{
				case 0:
					//Console.WriteLine("Value is zero");
					break;
				case 1:
					//Console.WriteLine("Value is one");
					break;
				case 3:
					//Console.WriteLine("Value is three");
					break;
				default:
					//Console.WriteLine("Value is neither 0, 1, 3");
					break;
			}

			// Mathematical operators: +, -, /, *, %, +=, *=, ++, --
			var aNumber = 10;
			aNumber += 20; // aNumber = aNumber + 20
			aNumber *= 5; // aNumber = aNumber * 5

			// Logical operators: AND (&&), OR (||), NOT (!)
			// ==, !=, <, >, <=, >= 

			// C# is a type-safe programming language!
			var myInteger = 0.5f;

			// Tertary conditional statement syntax
			var myNumber = 5;
			if (myNumber % 2 == 0)
			{
				//Console.WriteLine($"{myNumber} is even");
			}
			else
			{
				//Console.WriteLine($"{myNumber} is odd");
			}

			//Console.WriteLine(myNumber % 2 == 0 ? $"{myNumber} is even" : $"{myNumber} is odd");

			// Visibility modifiers
			// public: accessibility is available everywhere
			// private: accessibility is only available within the scope the item being defined
			// protected: accessibility is only available within the inherited hierachy
			// internal: accessibility is only available within the same assembly

			// class vs object
			// object = instance
			var aPerson = new ClassicPerson("John", "Doe", 20);
			aPerson.SetFirstName("Jane");

			// 
			//var aPerson2 = new Person
			//{
			//	FirstName = "John",
			//	LastName = "Doe",
			//	Age = 20
			//};
			//Console.WriteLine($"FirstName = {aPerson2.FirstName}");
			//aPerson2.FirstName = "Jane";
			//Console.WriteLine($"Full name = {aPerson2.GetFullName()}");

			// Inheritance
			var aStudent = new Student
			{
				FirstName = "Ray",
				LastName = "Nham",
				Age = 25,
				StudentId = 112233
			};
			//Console.WriteLine($"Full name = {aStudent.GetFullName()}");

			// Abstract class
			// Interfaces

			//Polymorphism: poly = many, phism = forms
			var people = new List<Person>();

			var person = new Person
			{
				FirstName = "John",
				LastName = "Doe"
			};

			people.Add(person);

			person = new Person
			{
				FirstName = "Jane",
				LastName = "Doe"
			};

			people.Add(person);

			var lecturer = new Lecturer
			{
				FirstName = "Micheal",
				LastName = "Robinson",
				StaffId = 183743
			};

			people.Add(lecturer);

			foreach(var p in people)
			{
				//Console.WriteLine(p.GetFullName(true));
			}

			// NULL ? nothing
			// what can be NULL ? variable
			// what kind variable can be NULL ? string
			// why? Reference type

			var nullablePerson = new Person
			{
				FirstName = "John",
				LastName = "Doe"
			};

			Console.WriteLine(nullablePerson.GetFullName());

			//nullablePerson = null;

			Console.WriteLine(nullablePerson?.GetFullName());

			// can primitive type be null? No
			// can we make primitive data type to allow null? Yes

			nullablePerson.Age = null;

			// C# Classes


			Console.ReadLine();
		}
	}
}
