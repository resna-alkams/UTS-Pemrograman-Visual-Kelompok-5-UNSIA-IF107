Imports System.Drawing.Text

Public Class FrLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Login.Click

    End Sub

    Private Sub button3_click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        FrPelapor.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As New FrPetugas()
        p.Show()
        Me.Hide()
    End Sub

    Private Sub FrLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleData.LoadFromFile()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim credits As String =
            "Kelompok 5 Pemrograman Visual UNSIA IF107" & vbCrLf &
            "- Desainer UI: Raihan Aly Kanz Pane" & vbCrLf &
            "- Programmer:Chandra Dyan Nugraha" & vbCrLf &
            "- Dokumentasi & Penyusunan Power Point: Widia Indriyani" & vbCrLf &
            "- Tester & Saran Alur Logika Aplikasi: Nauval Abdi Rahman" & vbCrLf &
            "- Ide dan Konsep Aplikasi: Afif Ihsan Maulana"

        MessageBox.Show(credits, "Di buat oleh orang - orang hebat di Kelompok 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class

