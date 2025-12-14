<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Login = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.BackColor = SystemColors.ButtonHighlight
        Login.FlatStyle = FlatStyle.Flat
        Login.Location = New Point(198, 126)
        Login.Name = "Login"
        Login.Size = New Size(116, 20)
        Login.TabIndex = 0
        Login.Text = "Masuk Sebagai :"
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Location = New Point(208, 210)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 30)
        Button2.TabIndex = 2
        Button2.Text = "Petugas"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.Location = New Point(208, 175)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 30)
        Button3.TabIndex = 3
        Button3.Text = "Pelapor"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button4.Location = New Point(12, 371)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 8
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button5.Location = New Point(12, 336)
        Button5.Name = "Button5"
        Button5.Size = New Size(136, 29)
        Button5.TabIndex = 9
        Button5.Text = "Tentang Aplikasi"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' FrLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(473, 412)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Login)
        Name = "FrLogin"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class
