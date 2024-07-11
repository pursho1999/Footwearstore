Imports System.Data.SqlClient
Public Class Bills

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Purshottam Singh\Documents\FootWearVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Public Property UN As String

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

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        lblUname.Text = UN
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub
    Dim Key = 0
    Dim Stock = 0
    Dim i = 0
    Dim GrdTotal = 0


    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub BillDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDGV.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Updater()

        Dim NewQuantity = Stock - Convert.ToInt32(txtQuantity.Text)
        con.Open()
        Dim query As String
        query = "Update ShoeTbl set Quantity=" & NewQuantity & " where SId=" & Key & " "
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Updated Successfully")
        con.Close()
        populate()
    End Sub

    Private Sub btnATB_Click(sender As Object, e As EventArgs) Handles btnATB.Click
        Try
            If txtQuantity.Text = "" Then
                MsgBox("Enter Quantity ")

            ElseIf txtItem.Text = "" Then
                MsgBox("Select The Item")

            ElseIf Convert.ToInt32(txtQuantity.Text) > Stock Then
                MsgBox("Not Enought Stock!! Please Try Again Later...")

            ElseIf txtCName.Text = "" Then
                MsgBox("Enter The Clients Name!")
            Else
                Dim rnum As Integer = BillDGV.Rows.Add()
                i = i + 1
                Dim Total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text)




                BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
                BillDGV.Rows.Item(rnum).Cells("Column2").Value = txtItem.Text
                BillDGV.Rows.Item(rnum).Cells("Column3").Value = txtPrice.Text
                BillDGV.Rows.Item(rnum).Cells("Column4").Value = txtQuantity.Text
                BillDGV.Rows.Item(rnum).Cells("Column5").Value = Total

                Dim Tot As String
                Tot = "Rs" + Convert.ToString(GrdTotal)
                GrdTotal = GrdTotal + Total
                'lblTotal.Text = Tot

                Dim Sum As Decimal = 0
                For i = 0 To BillDGV.Rows.Count - 1
                    Sum += BillDGV.Rows(i).Cells(4).Value
                    lblTotal.Text = Sum
                Next

                lblRs.Visible = True
                Updater()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShoeDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShoeDGV.CellContentClick
        Try

            Dim row As DataGridViewRow = ShoeDGV.Rows(e.RowIndex)
            txtItem.Text = row.Cells(1).Value.ToString
            txtPrice.Text = row.Cells(5).Value.ToString

            Stock = Convert.ToInt32(row.Cells(4).Value.ToString)

            If txtItem.Text = "" Then
                Key = 0
            Else
                Key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Reset()
        Key = 0
        txtCName.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        txtItem.Text = ""
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("ShoeShop", New Font("Century Gothic", 25, FontStyle.Bold), Brushes.MidnightBlue, 350, 40)
        e.Graphics.DrawString("-----Your Bill----", New Font("Century Gothic", 16), Brushes.MidnightBlue, 350, 90)

        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 100, 120)
        e.Graphics.DrawString("Total Amount Rs " + GrdTotal.ToString, New Font("Century Gothic", 15), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("Thanks For Buying", New Font("Century Gothic", 15), Brushes.Crimson, 300, 580)

    End Sub
    Private Sub AddBill()
        con.Open()
        Try
            Dim query As String
            query = "insert into BillTbl values('" & lblUname.Text & "','" & txtCName.Text & "'," & GrdTotal & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            ' MsgBox("Bill Saved Successfully")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Show()
        AddBill()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub
End Class