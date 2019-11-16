using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter Decimal Number:");
		var dec = Console.ReadLine();
		Console.WriteLine(calcul(Decimal.Parse(dec)));
	}
	public static decimal calcul(decimal price)
	{
		string num = price.ToString();
		var dig = num.Substring(num.Length-1,1);
		
		if(dig == "3" || dig=="4" || dig=="6" || dig=="7")
 
		{
			return Decimal.Parse(num.Substring(0,num.Length-1) + 5);
		}
		else if(dig == "2" || dig == "1" )
		{
			return Decimal.Parse(num.Substring(0,num.Length-1) + 0);
		}
		else if(dig == "8" )
		{
			
			return Decimal.Parse(num) + 0.02m;
		}
		else if(dig == "9" )
		{
			return (Decimal.Parse(num))+0.01m;
		}
		return Decimal.Parse(num);
	}
}
