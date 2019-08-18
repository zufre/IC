using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugWeek1Demo3
{
	class Program
	{
		public delegate int MyDelegate(int i, int j);
		public static int Add(int num1, int num2) => num1 + num2;

		public static int Subtract(int num1, int num2) => num1 - num2;
		static void Main(string[] args)
		{
			// Delegates
			// a variable type that can reference to a function.

			// Declaration
			MyDelegate myFunction = Add;
			Console.WriteLine($"Sum = {myFunction(1, 1)}"); // 2

			myFunction = Subtract;
            
            Console.WriteLine($"Subtraction = {myFunction(1, 1)}"); // 0

			myFunction = (int num1, int num2) => {
				Console.WriteLine("Calculation begins!");
				return num1 * num2;
			};
            myFunction(2, 3);
			// Events
			// message sent by something to trigger something else.
			var myBank = new Bank();
			myBank.BalanceChanged += delegate (double newValue)
			{
				Console.WriteLine($"The current balance is: {newValue}");
                Console.WriteLine($"Bank balance updated");
            };
            myBank.SendMessage += delegate (string word1, string word2)
            {
                Console.WriteLine($"{word1} {word2}");
            };

		
			myBank.BankBalance = 1000;
			myBank.BankBalance = 2000;
			myBank.BankBalance = 3000;
            Console.WriteLine(myBank.BankBalance);

			Console.ReadLine();

		}
	}
}
