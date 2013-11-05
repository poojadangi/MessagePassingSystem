Imports System.Data.OleDb
Public Class Forgotpass
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim str As String

   Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox1.Items.Add("WHAT IS YOUR FATHER NAME")
        ComboBox1.Items.Add("WHAT IS YOUR PET NAME")
        ComboBox1.Items.Add("WHAT IS YOUR AUNT NAME")
        ComboBox1.Items.Add("WHAT IS YOUR BIRTH PLACE")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from faculty where funame='" + TextBox1.Text + "' and fsecq='" + ComboBox1.SelectedItem + "'and fans='" + TextBox5.Text + "' "
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            str = reader(8).ToString
            MsgBox("Your password is=" + str)
        End If
    End Sub

    Private Sub Forgotpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")
        ComboBox1.Items.Add("what is your father name")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class