Imports System
Imports System.Collections.Generic

Public Class Program
    Public Shared Sub Main()
        Console.WriteLine(anagram("OnEeT", "n        Et o e"))
    End Sub

    Public Shared Function fib(ByVal num As Integer) As Integer
        Dim res As List(Of Integer) = New List(Of Integer) From {
            0,
            1
        }

        For i As Integer = 2 To num
            Dim a As Integer = res(i - 1)
            Dim b As Integer = res(i - 2)
            res.Add(a + b)
        Next

        Return res(num)
    End Function

    Public Shared Function anagram(ByVal strA As String, ByVal strB As String) As Boolean
        If cleanedString(strA) = cleanedString(strB) Then
            Return True
        End If

        Return False
    End Function

    Public Shared Function cleanedString(ByVal str As String) As String
        Console.WriteLine(str)
        str = str.Replace(" ", "").ToLower()
        Console.WriteLine(str)
        Dim arr As Char() = New Char(str.Length - 1) {}

        For i As Integer = 0 To str.Length - 1
            arr(i) = str(i)
        Next

        Array.Sort(arr)
        Dim newStr As String = ""

        For Each i As Char In arr
            newStr += i
        Next

        Console.WriteLine(newStr)
        Return newStr
    End Function

    Public Shared Sub fizzBuzz(ByVal num As Integer)
        For i As Integer = 0 To num

            If i Mod 3 = 0 AndAlso i Mod 5 = 0 Then
                Console.WriteLine("buzzFuzz")
            ElseIf i Mod 3 = 0 Then
                Console.WriteLine("buzz")
            ElseIf i Mod 5 = 0 Then
                Console.WriteLine("Fuzz")
            Else
                Console.WriteLine(i)
            End If
        Next
    End Sub
End Class
