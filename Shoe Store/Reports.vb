Public Class Reports
    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        Dim obj = New AboutUs()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        Dim obj = New Dashboard()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim obj = New Users()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnShoes_Click(sender As Object, e As EventArgs) Handles btnShoes.Click
        Dim obj = New Shoe()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()

    End Sub

    Private Sub btnRepUser_Click(sender As Object, e As EventArgs) Handles btnRepUser.Click
        Dim obj = New repUser()
        obj.Show()
    End Sub

    Private Sub btnRepItem_Click(sender As Object, e As EventArgs) Handles btnRepItem.Click
        Dim obj = New repItem()
        obj.Show()
    End Sub

    Private Sub btnRepBill_Click(sender As Object, e As EventArgs) Handles btnRepBill.Click
        Dim obj = New repBill()
        obj.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub
End Class