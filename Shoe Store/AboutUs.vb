Public Class AboutUs
    Private Sub AboutUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnShoes_Click(sender As Object, e As EventArgs) Handles btnShoes.Click
        Dim obj = New Shoe
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim obj = New Users
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        Dim obj = New Dashboard
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub picPs_MouseHover(sender As Object, e As EventArgs) Handles picPs.MouseHover

        LABELCLG.Visible = True
        LABELCLASS.Visible = True
        LABELNAME.Visible = True
        LABELNAME.Visible = True
        LABELNAME.Visible = True

    End Sub
    Private Sub picAr_MouseHover(sender As Object, e As EventArgs)

        LABELCLG.Visible = True
        LABELCLASS.Visible = True
        LABELNAME.Visible = True
        LABELNAME.Visible = True
        LABELNAME.Visible = True
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim obj = New Reports()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        LABELNAME.Visible = False
        LABELNAME.Visible = False
        LABELNAME.Visible = False
        LABELCLG.Visible = False
        LABELCLASS.Visible = False
    End Sub

    Private Sub LABELCLASS_Click(sender As Object, e As EventArgs) Handles LABELCLASS.Click

    End Sub
End Class