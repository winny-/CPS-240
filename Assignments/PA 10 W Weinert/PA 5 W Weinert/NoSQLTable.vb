Option Strict On

Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class NoSQLTable

    Public Property Connection As OleDbConnection
    Public Property TableName As String

    Public Sub New(connection As OleDbConnection, tableName As String)
        Me.Connection = connection
        Me.TableName = tableName
    End Sub

    Public Function GetValue(key As String, ByRef value As Object) As Boolean
        Dim command As OleDbCommand = Connection.CreateCommand()
        command.CommandText = String.Format("SELECT * FROM {0} WHERE [Key]=?", TableName)
        With command.Parameters
            .Add("@Key", OleDbType.VarWChar).Value = key
        End With
        Debug.WriteLine(String.Format("Executing command ""{0}""", command.CommandText))
        Dim reader As OleDb.OleDbDataReader = command.ExecuteReader()
        If reader.HasRows AndAlso reader.Read() Then
            Dim valueString As String = CStr(reader(1))
            value = Base64StringToObject(valueString)
        End If

        Return reader.HasRows
    End Function

    Public Function SetValue(key As String, value As Object) As Boolean
        Dim valueString = ObjectToBase64String(value)
        Dim command As OleDbCommand = Connection.CreateCommand()
        If GetValue(key, Nothing) Then
            command.CommandText = String.Format("UPDATE {0} SET Base64Data=? WHERE [Key]=?", TableName)
            With command.Parameters
                .Add("@Value", OleDbType.LongVarWChar).Value = valueString
                .Add("@Key", OleDbType.VarWChar).Value = key
            End With
        Else
            command.CommandText = String.Format("INSERT INTO {0} VALUES (?, ?)", TableName)
            With command.Parameters
                .Add("@Key", OleDbType.VarWChar).Value = key
                .Add("@Value", OleDbType.LongVarWChar).Value = valueString
            End With
        End If
        'Command.CommandText = String.Format("INSERT INTO {0} VALUES (?, ?) ON DUPLICATE KEY UPDATE Base64Data=?;", TableName)

        ''        command.CommandText = String.Format(<![CDATA[
        ''IF EXISTS (SELECT * FROM {0} WHERE [Key]=?)
        ''    UPDATE {1} SET Base64Data=? WHERE [Key]=?
        ''ELSE
        ''    INSERT INTO {2} VALUES(?, ?)
        '']]>.Value, TableName, TableName, TableName)
        'With command.Parameters
        '    '.Add("@Key", OleDbType.VarWChar).Value = key

        '    '.Add("@Value", OleDbType.LongVarWChar).Value = valueString
        '    '.Add("@Key", OleDbType.VarWChar).Value = key

        '    .Add("@Key", OleDbType.VarWChar).Value = key
        '    .Add("@Value", OleDbType.LongVarWChar).Value = valueString

        '    .Add("@Value", OleDbType.LongVarWChar).Value = valueString
        '    '.Add("@Key", OleDbType.VarWChar).Value = key
        'End With

        Debug.WriteLine(String.Format("Executing command ""{0}""", command.CommandText))

        Return command.ExecuteNonQuery() = 1
    End Function

    Private Shared Function ObjectToBase64String(obj As Object) As String
        Dim s As New MemoryStream()
        Dim formatter As New BinaryFormatter()
        formatter.Serialize(s, obj)
        Return Convert.ToBase64String(s.GetBuffer())
    End Function

    Private Shared Function Base64StringToObject(s As String) As Object
        Dim bytes() As Byte = Convert.FromBase64String(s)
        Dim ms As New MemoryStream(bytes)
        Dim formatter As New BinaryFormatter()
        Return formatter.Deserialize(ms)
    End Function

End Class
