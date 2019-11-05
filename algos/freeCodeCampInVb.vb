Imports System
				
Public Module Module1
	

Public Class Program
    Public Shared Sub Main()
        Dim intArray As Integer(,) = New Integer(3, 3) {
        {1, 2, 3, 5},
        {1, 33, 3, 4},
        {1, 55, 3, 4},
        {22, 2, 3, 4}}
		For Each item AS Integer In larg(intArray) 
		Console.WriteLine(item)
	Next
	
        
    End Sub

    Public Shared Function larg(ByVal arr As Integer(,)) As Integer()
        Dim newArr As Integer() = New Integer(3) {}

        For i As Integer = 0 To 4 - 1
            Dim largestNum As Integer = 0

            For a As Integer = 0 To 4 - 1

                If arr(i, a) > largestNum Then
                    largestNum = arr(i, a)
                End If
            Next

            newArr(i) = largestNum
        Next

        Return newArr
    End Function

	Public Function findLongestWordLength(ByVal str As String) As Integer
		Dim maxNum As Integer =1
		Dim arr As String() = str.Split(" ")
		For Each word As String In arr
		If word.Length > maxNum 
			maxNum = word.Length
		End If
		Next
		Return maxNum
	End Function
	Public Function toF(ByVal cel As Integer ) As Double
		
		Return cel *9/5+32
		
	End Function
	Public Function reverseString(ByVal str As String) As String
		Dim arr As Char() = str.ToCharArray()
		Array.Reverse(arr)
		Dim s As String = String.join("",arr)
		Return s
		
	End Function
	Public Function factorize(ByVal num As Integer) As Integer
		Dim res As Integer = 1
		For i As Integer = 1 To num
		res *= i
		Next
	Return res
	End Function
End Class
End Module
