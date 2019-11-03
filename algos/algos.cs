using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		//Console.WriteLine(fib(6));
		Console.WriteLine(maxChar("wwwwwwwwwwwwwwweeeeeert"));
		//fizzBuzz(21);
		//Console.WriteLine(anagram("OnEeT", "n        Et o e"));
		
	}
	
    static int ASCII_SIZE = 256; 
      
    public static char maxChar(String str) 
    { 
        // Create array to keep the count of 
        // individual characters and  
        // initialize the array as 0 
        int []count = new int[ASCII_SIZE]; 
      
        // Construct character count array 
        // from the input string. 
        int len = str.Length; 
        for (int i = 0; i < len; i++) 
            count[str[i]]++; 
      
        int max = -1; // Initialize max count 
        char result = ' '; // Initialize result 
      
        // Traversing through the string and  
        // maintaining the count of each character 
        for (int i = 0; i < len; i++) { 
            if (max < count[str[i]]) { 
                max = count[str[i]]; 
                result = str[i]; 
            } 
        } 
        return result; 
	}	
		
	public static int reverseInt(int num)
	{
		var absNum= num < 0? num * (-1) : num;
		
		var arr = absNum.ToString().ToCharArray().Reverse();
		var str = String.Join("",arr);
		
		return num < 0 ? Int32.Parse(str)*(-1) : Int32.Parse(str);
	}
	public static string reverse(string str)
	{
		var arr = str.ToCharArray().Reverse();
			return String.Join("",arr);
	}
	public static int fib(int num)
	{
		List<int> res = new List<int>{0,1};
		for(int i= 2; i<=num;i++)
		{
			int a = res[i-1];
			int b = res[i-2];
			res.Add(a+b);
		}
		
		return res[num];
		
	}
	 public static bool IsPalindrome(string str) 
    {
	  str = str.ToLower();
		
		var strArray = str.ToCharArray();
		
		Array.Reverse(strArray);
				
		return (new string(strArray)).Equals(str); 
    }
	public static bool anagram(string strA, string strB){
		if (cleanedString(strA) == cleanedString(strB)) {
			return true;	
		}
		return false;
	}
	public static string cleanedString(string str) {
		Console.WriteLine(str);
		str = str.Replace(" ", "").ToLower();
		Console.WriteLine(str);
		char[] arr = new char[str.Length];
		
		for (int i =0; i<str.Length;i++) {
			arr[i] = str[i];
		}
		
		 Array.Sort(arr);
		string newStr ="";
		foreach(char i in arr )
		{
			newStr+=i;
		}
		Console.WriteLine(newStr);
		return newStr;
	}
	
	public static void fizzBuzz(int num)
	{
		for (int i = 0; i<=num; i++) 
		{
			if( i %3==0 && i %5==0)
			{
				Console.WriteLine("buzzFuzz");
				
			}
			else if ( i % 3==0 )
			{
				Console.WriteLine("buzz");
				
			}
			else if (i %5==0 )
			{
				Console.WriteLine("Fuzz");
				
			}
			else
			{
				Console.WriteLine(i);
				
			}
			
				
		}
	}
}
