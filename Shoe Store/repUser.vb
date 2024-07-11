Public Class repUser
    Private Sub repUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RepFootWears.UserTbl' table. You can move, or remove it, as needed.
        Me.UserTblTableAdapter.Fill(Me.RepFootWears.UserTbl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class