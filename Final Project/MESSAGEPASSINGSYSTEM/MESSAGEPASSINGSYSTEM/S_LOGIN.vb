Imports System.Data.OleDb
Public Class S_LOGIN
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Documents and Settings\205112004\Desktop\mps.accdb")
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub S_LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openconnection()
        cmd.CommandText = "select * from slogin where susername='" + TextBox1.Text + "' and spassword='" + TextBox2.Text + "'"
        cmd.Connection = con
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            Dim I As Integer
            I = MsgBox("You have successfully logged on", MsgBoxStyle.YesNo + MsgBoxStyle.Information, Title:="LOGIN")
            If I = MsgBoxResult.Yes Then

                Me.Hide()

            End If

            Dim f2 As S_PROFILE = New S_PROFILE
            f2.Show()
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then


            MsgBox("please enter username and password", MsgBoxStyle.Information, MsgBoxStyle.OkCancel)
            If MsgBoxResult.Ok Then
                con.Close()
                TextBox1.Focus()
            End If
        End If

    End Sub
    Public Sub openconnection()
        Try
            con.Open()

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Forgotpass.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form2.Show()
    End Sub
End Class