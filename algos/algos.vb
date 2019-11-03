Imports System
Imports System.Collections.Generic
				
Public Class Module1
	Public Sub Main()
		Console.WriteLine(anagram("neo ret","On e re t"))
	End Sub
	Public shared Function IsPalindrome(ByVal str As String) As Boolean
    
	  str = str.ToLower()
		
		Dim strArray = str.ToCharArray()
		
		Array.Reverse(strArray)
				
		return (new string(strArray)).Equals(str)
	End Function
	Public shared Function anagram(ByVal strA As string, strB As String) As Boolean
		If cleanedString(strA) = cleanedString(strB) 
			Return true	
		End If
		Return false
	End Function

	Public shared Function cleanedString(ByVal str As String ) As String 
		
		str = str.Replace(" ", "").ToLower()
		
		Dim arr As Char()  = New Char(str.Length){}
		
		For i AS Integer = 0 To str.Length-1
			arr(i) = str(i)
	Next
		
		 Array.Sort(arr)
	DIM newStr AS String = ""
	For Each i As char in arr
		
			newStr+=i
		
Next
		
		Return newStr
		End Function

	Public Shared Function fractorial(ByVal num As Integer) As Integer
		
		If num = 0
				Return 1
		End If
		Return num * fractorial(num-1)
	End Function
	Public Shared Function fib(ByVal num As Integer) As Integer
		If num = 0 Then
			Return 0
		Else If num = 1 Then
				Return 1
		End If
			Return fib(num-1) + fib(num-2)
			
		End Function
		Public Shared Function fibo(ByVal num As Integer) As Integer
			Dim res As List(Of Integer) =New List(Of Integer) From {
				0,
				1
				}
			
			 
			For i As Integer = 2  to Num
			Dim a As Integer = num-1
			Dim b As Integer = num -2
			res.Add(a+b)
		Next
		Return res(num)
		
		
		
			
		End Function
	Public Sub fizzBuzz(ByVal num As Integer)
		For i As Integer = 0 To num
		If i Mod 3 = 0 AndAlso i Mod 5 = 0 Then
			Console.WriteLine("fizzBuzz") 
		ElseIf i Mod 3= 0	Then
			Console.WriteLine("fizz") 
	ElseIf i Mod 5=0	Then
			Console.WriteLine("buss") 
		Else 
			Console.WriteLine(i) 
		End If
		Next
		
	End Sub
End Class 
