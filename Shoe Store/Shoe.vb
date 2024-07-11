Imports System.Data.SqlClient
Public Class Shoe
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Purshottam Singh\Documents\FootWearVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub populate()
        con.Open()
        Dim query = "select * from ShoeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)

        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)

        Dim ds As New DataSet
        adapter.Fill(ds)
        ShoeDGV.DataSource = ds.Tables(0)

        con.Close()

    End Sub
    Private Sub Filter()
        con.Open()
        Dim query = "select * from ShoeTbl where Category='" & cmbFilter.SelectedItem.ToString() & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)

        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)

        Dim ds As New DataSet
        adapter.Fill(ds)
        ShoeDGV.DataSource = ds.Tables(0)

        con.Close()

    End Sub
    Private Sub Reset()
        txtShoeName.Text = ""
        txtBrand.Text = ""
        txtQuantity.Text = ""
        txtPrice.Text = ""
        cmbCat.SelectedIndex = -1
        Key = 0
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtShoeName.Text = "" Or txtBrand.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cmbCat.SelectedIndex = -1 Then
            MsgBox("Please Enter All The Details")
        Else
            con.Open()
            Dim query As String
            query = "insert into ShoeTbl values('" & txtShoeName.Text & "','" & txtBrand.Text & "','" & cmbCat.SelectedItem.ToString & "','" & txtQuantity.Text & "','" & txtPrice.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Saved Successfully")
            con.Close()
            populate()
            Reset()

        End If
    End Sub



    Private Sub lblClose_Click_1(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub


    Dim Key = 0
    Private Sub ShoeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ShoeDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = ShoeDGV.Rows(e.RowIndex)
            txtShoeName.Text = row.Cells(1).Value.ToString
            txtBrand.Text = row.Cells(2).Value.ToString
            cmbCat.SelectedItem = row.Cells(3).Value.ToString
            txtQuantity.Text = row.Cells(4).Value.ToString
            txtPrice.Text = row.Cells(5).Value.ToString
            If txtShoeName.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Shoe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Select The Item To be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "Delete from ShoeTbl where SId=" & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted Successfully")
            con.Close()
            populate()
            Reset()

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtShoeName.Text = "" Or txtBrand.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cmbCat.SelectedIndex = -1 Then
            MsgBox("Please Enter All The Details")
        Else
            con.Open()
            Dim query As String
            query = "Update ShoeTbl set Title='" & txtShoeName.Text & "',Brand='" & txtBrand.Text & "',Category='" & cmbCat.SelectedItem.ToString & "',Quantity='" & txtQuantity.Text & "',Price='" & txtPrice.Text & "' where SId=" & Key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Updated Successfully")
            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbFilter.SelectionChangeCommitted


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        populate()

    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Filter()
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


    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim obj = New Users()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim obj = New Reports()
        obj.Show()
        Me.Hide()
    End Sub
End Class