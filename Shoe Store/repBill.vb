Public Class repBill
    Private Sub repBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RepFootWears.BillTbl' table. You can move, or remove it, as needed.
        Me.BillTblTableAdapter.Fill(Me.RepFootWears.BillTbl)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class