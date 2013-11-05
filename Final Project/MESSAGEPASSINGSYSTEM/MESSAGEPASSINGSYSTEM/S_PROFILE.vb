Public Class S_PROFILE

    Private Sub INBOXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INBOXToolStripMenuItem.Click
        INBOX.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class