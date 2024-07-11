Imports System.Data.SqlClient

Public Class Users

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Purshottam Singh\Documents\FootWearVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub populate()
        con.Open()
        Dim query = "select * from UserTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)

        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)

        Dim ds As New DataSet
        adapter.Fill(ds)
        UserDGV.DataSource = ds.Tables(0)

        con.Close()

    End Sub
    Private Sub Reset()
        txtUname.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtPassword.Text = ""
        Key = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUname.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Enter All The Details")
        Else
            con.Open()
            Dim query As String
            query = "insert into UserTbl values('" & txtUname.Text & "','" & txtPhone.Text & "','" & txtAddress.Text & "','" & txtPassword.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Saved Successfully")
            con.Close()
            populate()
            Reset()

        End If
    End Sub
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub lblClose_Click_1(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()

    End Sub

    Dim Key = 0

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Select User To be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "Delete from UserTbl where Id=" & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Successfully")
            con.Close()
            populate()
            Reset()

        End If
    End Sub

    Private Sub UserDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = UserDGV.Rows(e.RowIndex)
            txtUname.Text = row.Cells(1).Value.ToString
            txtPhone.Text = row.Cells(2).Value.ToString
            txtAddress.Text = row.Cells(3).Value.ToString
            txtPassword.Text = row.Cells(4).Value.ToString
            If txtUname.Text = "" Then
                Key = 0

            Else
                Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtUname.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Enter All The Details")
        Else
            con.Open()
            Dim query As String
            query = "Update UserTbl set Name='" & txtUname.Text & "',Phone='" & txtPhone.Text & "',Address='" & txtAddress.Text & "',Password='" & txtPassword.Text & "' where Id=" & Key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Successfully")
            con.Close()
            populate()
            Reset()

        End If
    End Sub

    Private Sub btnSports_Click(sender As Object, e As EventArgs) Handles btnSports.Click
        Dim obj = New Shoe()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        Dim obj = New Dashboard()
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

    Private Sub UserDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDGV.CellContentClick

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim obj = New Reports()
        obj.Show()
        Me.Hide()
    End Sub
End Class