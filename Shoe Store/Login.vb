Imports System.Data.SqlClient
Public Class Login
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Purshottam Singh\Documents\FootWearVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()

    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUser.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter Your Username And Password")



        Else
            con.Open()
            Dim query = "select * from Usertbl where  Name='" & txtUser.Text & "'and Password='" & txtPassword.Text & "'"
            cmd = New SqlCommand(query, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username Or Password")
            Else
                Dim Bill = New Bills
                Bills.UN = txtUser.Text
                Bill.UN = txtUser.Text

                Bills.Show()
                Me.Hide()

            End If
            con.Close()


        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj = New AdminLogin
        obj.Show()
        Me.Hide()
    End Sub
End Class
