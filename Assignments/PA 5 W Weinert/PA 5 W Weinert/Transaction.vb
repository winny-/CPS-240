Option Strict On

Partial Public Class Account

    ''' <summary>
    ''' A tranaction associated with an individual's bank account
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Transaction

        Public Enum TransactionType
            Withdrawal
            Deposit
        End Enum

        Private _Time As Date
        Private _Kind As TransactionType
        Private _Amount As Decimal
        Private _Account As Account
        Private _Balance As Decimal

        Public ReadOnly Property Time As Date
            Get
                Return _Time
            End Get
        End Property

        Public ReadOnly Property Kind As TransactionType
            Get
                Return _Kind
            End Get
        End Property

        Public ReadOnly Property Amount As Decimal
            Get
                Return _Amount
            End Get
        End Property

        Public ReadOnly Property Account As Account
            Get
                Return _Account
            End Get
        End Property

        Public ReadOnly Property Balance As Decimal
            Get
                Return _Balance
            End Get
        End Property

        Public Sub New(ByVal time As Date, ByVal kind As TransactionType, ByVal amount As Decimal, ByVal account As Account)
            _Time = time
            _Kind = kind
            _Amount = amount
            _Account = account
            _Balance = account.Funds
        End Sub

        Public Overrides Function ToString() As String
            Return ToString(withAccountName:=False)
        End Function

        Public Overloads Function ToString(ByVal withAccountName As Boolean) As String
            Dim accountNamePrefix As String = If(withAccountName, Account.Name & " ", "")
            Return String.Format("{0}{1} {2} {3:C}", accountNamePrefix, Time, Kind, Amount)
        End Function

    End Class

End Class
