Public Class F_PROFILE

    Private Sub SENDMESSAGEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SENDMESSAGEToolStripMenuItem.Click
        Message.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub F_PROFILE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("CA")
        ComboBox1.Items.Add("MATHEMATICS")
        ComboBox2.Items.Add("MCA")
        ComboBox2.Items.Add("MSC")
        ComboBox2.Items.Add("MTECH")
        ComboBox3.Items.Add("FIRST")
        ComboBox3.Items.Add("SECOND")
        ComboBox3.Items.Add("THIRD")
    End Sub
End Class