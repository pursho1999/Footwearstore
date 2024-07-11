Imports System.Data.SqlClient
Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Purshottam Singh\Documents\FootWearVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub countShoes()
        Dim ShoeNum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from Shoetbl"
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(sql, con)
        ShoeNum = cmd.ExecuteScalar
        lblShoes.Text = ShoeNum
        con.Close()
    End Sub
    Public Sub countUsers()
        Dim UserNum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from Usertbl"
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(sql, con)
        UserNum = cmd.ExecuteScalar
        lblUsers.Text = UserNum
        con.Close()
    End Sub
    Public Sub sumAmount()
        Dim AmtNum As Integer
        con.Open()
        Dim sql = "select Sum(Amount) from Billtbl"
        Dim cmd As New SqlCommand
        cmd = New SqlCommand(sql, con)
        AmtNum = cmd.ExecuteScalar
        lblAmount.Text = "Rs  " + Convert.ToString(AmtNum)
        con.Close()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        countShoes()
        countUsers()
        sumAmount()

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()

    End Sub

    Private Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblUsers.Click

    End Sub


    Private Sub btnShoes_Click(sender As Object, e As EventArgs) Handles btnShoes.Click
        Dim obj = New Shoe()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim obj = New Users()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        Dim obj = New AboutUs()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim obj = New Reports()
        obj.Show()
        Me.Hide()
    End Sub
End Class