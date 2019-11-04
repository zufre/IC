using System;
					
public class Program
{
	public static void Main()
	{
	 var myBank = new Bank();
		myBank.BalanceChanged += delegate(double newVal)
		{
			Console.WriteLine(newVal);
		};
		myBank.BankBalance =3000;
	}
	
}
public delegate void BankBalanceChanged(double newVal);

public class Bank {
	private double _balance;
	public event BankBalanceChanged BalanceChanged;
	
	public double BankBalance
	{
		get 
		{
			return _balance;
		}
		set
		{
			_balance = value;
			BalanceChanged(value);
		}
	
	}
}
