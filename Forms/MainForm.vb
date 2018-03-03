Public Class MainForm
    Private Sub FarmersButton_Click(sender As Object, e As EventArgs) Handles FarmersButton.Click
        MainGroupBox.Visible = False
        FarmersGroupBox.Visible = True
        FarmLocationsGroupBox.Visible = False

        DashboardButton.BackColor = Color.PaleGreen
        FarmersButton.BackColor = Color.LimeGreen
        FarmLocationsButton.BackColor = Color.PaleGreen
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        MainGroupBox.Visible = True
        FarmersGroupBox.Visible = False
        FarmLocationsGroupBox.Visible = False

        DashboardButton.BackColor = Color.LimeGreen
        FarmersButton.BackColor = Color.PaleGreen
        FarmLocationsButton.BackColor = Color.PaleGreen
    End Sub

    Private Sub FarmLocationsButton_Click(sender As Object, e As EventArgs) Handles FarmLocationsButton.Click
        MainGroupBox.Visible = False
        FarmersGroupBox.Visible = False
        FarmLocationsGroupBox.Visible = True

        DashboardButton.BackColor = Color.PaleGreen
        FarmersButton.BackColor = Color.PaleGreen
        FarmLocationsButton.BackColor = Color.LimeGreen
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
