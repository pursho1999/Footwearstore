Public Class repItem
    Private Sub repItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RepFootWears.ShoeTbl' table. You can move, or remove it, as needed.
        Me.ShoeTblTableAdapter.Fill(Me.RepFootWears.ShoeTbl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class