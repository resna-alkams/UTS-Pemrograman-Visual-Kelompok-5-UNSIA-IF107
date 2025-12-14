<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPetugas
    Inherits System.Windows.Forms.Form


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


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        ColFoto = New DataGridViewImageColumn()
        Button1 = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColFoto})
        DataGridView1.Location = New Point(12, 47)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 349)
        DataGridView1.TabIndex = 0
        ' 
        ' ColFoto
        ' 
        ColFoto.HeaderText = "Foto"
        ColFoto.MinimumWidth = 6
        ColFoto.Name = "ColFoto"
        ColFoto.Visible = False
        ColFoto.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 412)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 20)
        Label1.TabIndex = 3
        Label1.Text = "Jumlah Laporan:"
        ' 
        ' FrPetugas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "FrPetugas"
        Text = "Hasil Laporan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ColFoto As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
End Class
