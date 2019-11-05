Imports System
				
Public Module Module1
	Public Sub Main()
		REM Dim intArray As Integer(,) = New Integer(3, 3) {
        REM {1, 2, 3, 5},
       REM  {1, 33, 3, 4},
        REM {1, 55, 3, 4},
        REM {22, 2, 3, 4}}
		REM For Each item AS Integer In larg(intArray) 
		REM Console.WriteLine(item)
	REM Next
	Console.WriteLine(confirmEnding("If you want to save our world, you must hurry. We dont know how much longer we can withstand the nothing", "nothing"))
	End Sub
Public Function confirmEnding(ByVal str As String, target AS String) AS Boolean
	Dim lengthStr As Integer = str.Length
	Dim lengthTarget As Integer = target.Length
	
	If str.Substring(lengthStr-lengthTarget,lengthTarget)=target
		Return true
	Else 
		Return false
	End If
	
	End Function
	 Public Function larg(ByVal arr As Integer(,)) As Integer()
        Dim newArr As Integer() = New Integer(3) {}
		
        For i As Integer = 0 To 3
            Dim largestNum As Integer = 0

            For a As Integer = 0 To 3

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
End Module
