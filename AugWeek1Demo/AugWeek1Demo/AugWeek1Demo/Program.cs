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
			foreach(var number in intArray)
			{
				//Console.WriteLine(number);
			}

			// while
			var index = 0;
			while(index < intArray.Length)
			{
				Console.WriteLine(intArray[index++]);
				//index++; // index = index + 1
			}

			// do-while
			var index1 = 0;
			do
			{
				//Console.WriteLine(intArray[index1++]);
			} while (index1 < intArray.Length);

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
					Console.WriteLine("Value is zero");
					break;
				case 1:
					Console.WriteLine("Value is one");
					break;
				case 3:
					Console.WriteLine("Value is three");
					break;
				default:
					Console.WriteLine("Value is neither 0, 1, 3");
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

			Console.ReadLine();
		}
	}
}
