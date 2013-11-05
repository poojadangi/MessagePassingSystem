Imports System.Data.OleDb

Public Class Form2
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    'Dim da As OleDbDataAdapter
    ' Dim reader As OleDbDataReader
    ' Dim count As Integer
    'Dim query As String


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into student(rno,sname,dept,course,sem,sub,batch,cno,uname,pas,squestn,ans)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & ComboBox3.SelectedItem & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & ComboBox4.SelectedItem & "','" & TextBox5.Text & "')"

        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record successfully saved", MsgBoxStyle.DefaultButton1)
    End Sub

    Private Sub Form2_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        'con.Close()
    End Sub
    Private Sub Form2_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ss()
        ComboBox1.Items.Add("COMPUTER APPLICATIONS")
        ComboBox1.Items.Add("MATHEMATICS")
        ComboBox1.Items.Add("PHYSICS")
        ComboBox1.Items.Add("CIVIL")
        ComboBox1.Items.Add("ARCHITECTURE")
        ComboBox2.Items.Add("FIRST")
        ComboBox2.Items.Add("SECOND")
        ComboBox2.Items.Add("THIRD")
        ComboBox2.Items.Add("FORTH")
        ComboBox2.Items.Add("FIFTH")
        ComboBox3.Items.Add("OPERATING SYSTEM")
        ComboBox3.Items.Add("DATA MINING")
        ComboBox3.Items.Add("GRAPHICS ANG MULTIMEDIA")
        ComboBox3.Items.Add("OBJECT ORIENTED ANALYSIS AND DESIGN")
        ComboBox3.Items.Add("SOFTWARE ENGINEERING")
        ComboBox4.Items.Add("WHAT IS YOUR BEST FRIEND NAME")
        ComboBox4.Items.Add("WHAT IS YOUR PET NAME")
        ComboBox4.Items.Add("WHAT IS YOUR FAMILY DOCTOR NAME")
        ComboBox4.Items.Add("WHAT IS YOUR AUNT NAME")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class


