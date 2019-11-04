Imports System

Public Class Program
	Public Shared Sub Main()
        Dim myBank = New Bank()
        AddHandler myBank.BalanceChanged, Sub(ByVal newVal As Double)
                                              Console.WriteLine(newVal)
                                          End Sub

        myBank.BankBalance = 3000
	End Sub
End Class

Public Delegate Sub BankBalanceChanged(ByVal newVal As Double)

Public Class Bank
    Private _balance As Double
    Public Event BalanceChanged As BankBalanceChanged

    Public Property BankBalance As Double
        Get
            Return _balance
        End Get
        Set(ByVal value As Double)
            _balance = value
			RaiseEvent BalanceChanged(value)
        End Set
    End Property
End Class
