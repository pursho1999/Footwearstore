﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.UserTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepFootWears = New Shoe_Store.RepFootWears()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UserTblTableAdapter = New Shoe_Store.RepFootWearsTableAdapters.UserTblTableAdapter()
        CType(Me.UserTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepFootWears, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserTblBindingSource
        '
        Me.UserTblBindingSource.DataMember = "UserTbl"
        Me.UserTblBindingSource.DataSource = Me.RepFootWears
        '
        'RepFootWears
        '
        Me.RepFootWears.DataSetName = "RepFootWears"
        Me.RepFootWears.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.UserTblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Shoe_Store.2repUser.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'UserTblTableAdapter
        '
        Me.UserTblTableAdapter.ClearBeforeFill = True
        '
        'repUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "repUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "repUser"
        CType(Me.UserTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepFootWears, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UserTblBindingSource As BindingSource
    Friend WithEvents RepFootWears As RepFootWears
    Friend WithEvents UserTblTableAdapter As RepFootWearsTableAdapters.UserTblTableAdapter
End Class
