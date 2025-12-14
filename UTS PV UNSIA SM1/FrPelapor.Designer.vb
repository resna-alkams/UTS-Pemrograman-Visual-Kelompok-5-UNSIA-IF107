<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPelapor
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        textNama = New TextBox()
        textWhatsapp = New TextBox()
        TextLokasiKejadian = New TextBox()
        TextDeskripsiKejadian = New TextBox()
        ComboBoxKejadian = New ComboBox()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Button3 = New Button()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nomor Whatsapp :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 20)
        Label3.TabIndex = 2
        Label3.Text = "Lokasi Kejadian :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 20)
        Label4.TabIndex = 3
        Label4.Text = "Kategori Kejadian :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 20)
        Label5.TabIndex = 4
        Label5.Text = "Deskripsi Kejadian :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 216)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 20)
        Label6.TabIndex = 5
        Label6.Text = "Upload Foto :"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(548, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button2.Location = New Point(12, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' textNama
        ' 
        textNama.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        textNama.Location = New Point(229, 38)
        textNama.Name = "textNama"
        textNama.Size = New Size(395, 27)
        textNama.TabIndex = 8
        ' 
        ' textWhatsapp
        ' 
        textWhatsapp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        textWhatsapp.Location = New Point(229, 74)
        textWhatsapp.Name = "textWhatsapp"
        textWhatsapp.Size = New Size(395, 27)
        textWhatsapp.TabIndex = 9
        ' 
        ' TextLokasiKejadian
        ' 
        TextLokasiKejadian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TextLokasiKejadian.Location = New Point(229, 109)
        TextLokasiKejadian.Name = "TextLokasiKejadian"
        TextLokasiKejadian.Size = New Size(395, 27)
        TextLokasiKejadian.TabIndex = 10
        ' 
        ' TextDeskripsiKejadian
        ' 
        TextDeskripsiKejadian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TextDeskripsiKejadian.Location = New Point(229, 180)
        TextDeskripsiKejadian.Name = "TextDeskripsiKejadian"
        TextDeskripsiKejadian.Size = New Size(395, 27)
        TextDeskripsiKejadian.TabIndex = 12
        ' 
        ' ComboBoxKejadian
        ' 
        ComboBoxKejadian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        ComboBoxKejadian.FormattingEnabled = True
        ComboBoxKejadian.Items.AddRange(New Object() {"Jalan & Infrastruktur", "Kebersihan", "Keamanan", "Fasilitas Umum", "Lainnya"})
        ComboBoxKejadian.Location = New Point(229, 143)
        ComboBoxKejadian.Name = "ComboBoxKejadian"
        ComboBoxKejadian.Size = New Size(165, 28)
        ComboBoxKejadian.TabIndex = 13
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(229, 216)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(496, 216)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 29)
        Button3.TabIndex = 15
        Button3.Text = "Tambahkan Foto"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(496, 248)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 17)
        Label7.TabIndex = 16
        Label7.Text = "jpg, jpeg,png"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(630, 375)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Formulir Laporan"
        ' 
        ' FrPelapor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(654, 434)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBoxKejadian)
        Controls.Add(TextDeskripsiKejadian)
        Controls.Add(TextLokasiKejadian)
        Controls.Add(textWhatsapp)
        Controls.Add(textNama)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "FrPelapor"
        Text = "Data Kejadian"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents textNama As TextBox
    Friend WithEvents textWhatsapp As TextBox
    Friend WithEvents TextLokasiKejadian As TextBox
    Friend WithEvents TextDeskripsiKejadian As TextBox
    Friend WithEvents ComboBoxKejadian As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
