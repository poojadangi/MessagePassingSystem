Imports System.Data.OleDb
Public Class Form3
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    'Dim da As OleDbDataAdapter
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "insert into faculty(f_id,fname,fdept,fsem,fsub,fdesg,fqua,funame,fpass,fsecq,fans)values(" & Val(TextBox1.Text) & ",'" & TextBox2.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & ComboBox3.SelectedItem & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox4.SelectedItem & "','" & TextBox7.Text & "')"


        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Record successfully saved", MsgBoxStyle.DefaultButton1)
    End Sub
    Private Sub Form3_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        con.Close()
    End Sub

    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")

        ComboBox1.Items.Add("MCA")
        ComboBox1.Items.Add("MATHEMATICS")
        ComboBox1.Items.Add("PHYSICS")
        ComboBox2.Items.Add("FIRST")
        ComboBox2.Items.Add("SECOND")
        'ComboBox2.Items.Add("THIRD")
        'ComboBox2.Items.Add("FORTH")
        'ComboBox2.Items.Add("FIFTH")
        ComboBox3.Items.Add("mca")
        ComboBox4.Items.Add("what is your father name")

        
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.GotFocus
        If ComboBox1.SelectedItem = "MCA" And ComboBox2.SelectedItem = "FIRST" Then
            ComboBox3.Items.Add("ACCOUNTING AND FINANCIAL MANAGEMENT")
            ComboBox3.Items.Add("BUSINESS PROCESS")
            ComboBox3.Items.Add("DISCRETE MATHEMATICS")
            ComboBox3.Items.Add("PROCEDURAL ORIENTED LANGUAGE")
            ComboBox3.Items.Add("COMPUTER ORGANIZATION AND ARCHITECTURE")

        ElseIf ComboBox1.SelectedItem = "MCA" And ComboBox2.SelectedItem = "SECOND" Then
            ComboBox3.Items.Add("DATA STRUCTURE")
            ComboBox3.Items.Add("C++ PROGRAMING")
            ComboBox3.Items.Add("DATA BASE MANAGEMENT SYSTEM")
            ComboBox3.Items.Add("NETWORKING")
            ComboBox3.Items.Add("SOFTWARE ENGINEERING")

        ElseIf ComboBox1.SelectedItem = "MCA" And ComboBox2.SelectedItem = "THIRD" Then
            ComboBox3.Items.Add("OPERATING SYSTEM")
            ComboBox3.Items.Add("DATA MINING")
            ComboBox3.Items.Add("GRAPHICS ANG MULTIMEDIA")
            ComboBox3.Items.Add("OBJECT ORIENTED ANALYSIS AND DESIGN")
            ComboBox3.Items.Add("SOFTWARE ENGINEERING")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class