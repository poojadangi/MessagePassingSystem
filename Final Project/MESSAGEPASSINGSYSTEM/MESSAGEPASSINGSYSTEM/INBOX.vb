Imports System.Data.OleDb
Public Class INBOX
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub INBOX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        cmd.CommandText = "Select * from roll_msg where rollno='" + TextBox1.Text + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            TextBox2.Text = reader(1).ToString
            TextBox3.Text = reader(4).ToString
            TextBox4.Text = reader(3).ToString
            con.Close()
        End If
    End Sub
End Class