using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
					

public class Program
{
	public static void Main()
	{
		var str = "to existing defences and operational activitie.I do sound alarmed because we are in the middle of November and everywhere is saturated, he told reporters.All the flood storage areas are full. We have to be really vigilant because what I don't want is that horrendous 900 number to become a 10, 15, 20,000 number.Climate signal links global floods and firesThousands of homes to be built in flood zones Flooded Venice battles new tidal surge Last week saw 50-100mm of rainfall in an area from the Humber to Sheffield, the same amount as would normally be expected in the whole of the month of";	
		
		
		var list = wordCount(str);
		foreach (var pair in list.OrderBy(Key => Key.Value).Reverse())
			
		{
			Console.WriteLine("Word: {0}, Val:{1}",pair.Key, pair.Value);
		}
	}
	public static string cleanStr(string str) 
		
	{
		var n = Regex.Replace(str , "[^A-Za-z\\s]+",  " ");
		return Regex.Replace(n,"[\\s]{2,}"," ").ToLower();
	}
	public static Dictionary<String, int> wordCount(string text)	
	{	
		
		var arr = cleanStr(text).Split(' ');
		var unWords = new Dictionary<String, int>{};
		foreach(string word in arr)
		{
			if (!unWords.ContainsKey(word))
				{
					unWords.Add(word, 1);
				}
			else
				{
					var tempNum = unWords[word];
					tempNum+=1;
					unWords[word] = tempNum;
				}
		}
		return unWords;
	}
}
