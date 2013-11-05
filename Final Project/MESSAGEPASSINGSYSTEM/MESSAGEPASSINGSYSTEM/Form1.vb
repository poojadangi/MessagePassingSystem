Imports System.Data.OleDb
Public Class Form1
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader


   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openconnection()
        cmd.CommandText = "select * from login where uname='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            Dim I As Integer
            I = MsgBox("You have successfully logged on", MsgBoxStyle.YesNo + MsgBoxStyle.Information, Title:="LOGIN")
            If I = MsgBoxResult.Yes Then

                Me.Hide()

            End If

            Dim f2 As F_PROFILE = New F_PROFILE
            f2.Show()
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then


            MsgBox("please enter username and password", MsgBoxStyle.Information, MsgBoxStyle.OkCancel)
            If MsgBoxResult.Ok Then
                con.Close()
                TextBox1.Focus()
            End If
        End If

    End Sub
    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        con.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub openconnection()
        Try
            con.Open()

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

    End Sub
    


    
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Forgotpass.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form3.Show()
        ' Dim i As Integer
        'i = Val(InputBox("Enter the choice press 1 for create user as a faculty and press 2 for creatin user as a student"))
        'If i = 1 Then
        'Form3.Show()
        'ElseIf i = 2 Then
        'Form2.Show()
        'Else
        ' MsgBox("Please enter the correct value")
        ' End If
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
