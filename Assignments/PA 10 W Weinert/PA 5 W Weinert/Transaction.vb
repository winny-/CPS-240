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
        Private _UUID As Guid

        Public ReadOnly Property UUID As Guid
            Get
                Return _UUID
            End Get
        End Property

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

        Public Sub New(kind As TransactionType, amount As Decimal, account As Account)
            Me.New(DateTime.Now(), kind, amount, account, Guid.NewGuid())
        End Sub

        Public Sub New(ByVal time As Date, ByVal kind As TransactionType, ByVal amount As Decimal, ByVal account As Account, ByVal uuid As Guid)
            _Time = time
            _Kind = kind
            _Amount = amount
            _Account = account
            _Balance = account.Funds + amount * If(kind = TransactionType.Deposit, 1D, -1D)
            _UUID = uuid
        End Sub

        Public Overrides Function ToString() As String
            Return ToString(withAccountName:=False)
        End Function

        Public Overloads Function ToString(ByVal withAccountName As Boolean) As String
            Dim accountNamePrefix As String = If(withAccountName,
                                                 String.Format("{0} {1} ", Account.FirstName, Account.LastName),
                                                 "")
            Return String.Format("{0}{1} {2} {3:C}", accountNamePrefix, Time, Kind, Amount)
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            Dim otherTransaction As Transaction = TryCast(obj, Transaction)
            Return otherTransaction IsNot Nothing AndAlso Me.UUID = otherTransaction.UUID
        End Function

    End Class

End Class
