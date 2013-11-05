Imports System.Data.OleDb
Public Class Message
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand = New OleDbCommand
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        'cmd.CommandText = "insert into message(mdate,rollno,message)values('" & TextBox1.Text & "'," & Val(TextBox2.Text) & ",'" & TextBox3.Text & "')"
        If CheckedListBox1.CheckedItems.Count >= 1 And CheckedListBox1.CheckedItems.Count <= 10 Then
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO roll_msg(msgid,mdate,rollno,msg,fname)values(" & Val(TextBox2.Text) & ",'" & DateTimePicker1.Value & "'," & Val(CheckedListBox1.SelectedItem) & ",'" & TextBox1.Text & "','" & TextBox3.Text & "')"
            cmd.ExecuteNonQuery()
            con.Close()

        End If

        
        MsgBox("Record successfully saved", MsgBoxStyle.DefaultButton1)
    End Sub
    Private Sub Message_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")
        CheckedListBox1.Items.Add("205112001")
        CheckedListBox1.Items.Add("205112002")
        CheckedListBox1.Items.Add("205112003")
        CheckedListBox1.Items.Add("205112004")
        CheckedListBox1.Items.Add("205112005")
        CheckedListBox1.Items.Add("205112006")
        CheckedListBox1.Items.Add("205112007")
        CheckedListBox1.Items.Add("205112008")
        CheckedListBox1.Items.Add("205112009")
        CheckedListBox1.Items.Add("205112010")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class