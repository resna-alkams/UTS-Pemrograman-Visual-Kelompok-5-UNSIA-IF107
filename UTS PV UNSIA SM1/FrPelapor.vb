Public Class FrPelapor


    Private currentFotoPath As String = String.Empty

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textNama.TextChanged
        Dim NamaPelapor As String
    End Sub

    Private Sub textWhatsapp_TextChanged(sender As Object, e As EventArgs) Handles textWhatsapp.TextChanged
        Dim NoWAPelapor As String
    End Sub

    Private Sub TextLokasiKejadian_TextChanged(sender As Object, e As EventArgs) Handles TextLokasiKejadian.TextChanged
        Dim LokasiKejadianPelapor As String
    End Sub

    Private Sub TextDeskrpsiKejadian_TextChanged(sender As Object, e As EventArgs) Handles TextDeskripsiKejadian.TextChanged
        Dim DeskripsiKejadianPelapor As String
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If dlg.ShowDialog() = DialogResult.OK Then
            currentFotoPath = dlg.FileName
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom


            Using fs = IO.File.OpenRead(currentFotoPath)
                PictureBox1.Image = Image.FromStream(fs)
            End Using

        End If

    End Sub





    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBoxKejadian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKejadian.SelectedIndexChanged

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If textNama.Text.Trim() = "" Then
            MessageBox.Show("Nama belum diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textNama.Focus()
            Exit Sub
        End If

        If textWhatsapp.Text.Trim() = "" Then
            MessageBox.Show("Nomor Whatsapp belum diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textWhatsapp.Focus()
            Exit Sub
        End If

        If TextLokasiKejadian.Text.Trim() = "" Then
            MessageBox.Show("Lokasi Kejadian belum diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextLokasiKejadian.Focus()
            Exit Sub
        End If

        If TextDeskripsiKejadian.Text.Trim() = "" Then
            MessageBox.Show("Deskripsi Kejadian belum diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextDeskripsiKejadian.Focus()
            Exit Sub
        End If

        Dim item As New LaporanItem With {
        .Nama = textNama.Text,
        .NoHP = textWhatsapp.Text,
        .Alamat = TextLokasiKejadian.Text,
        .Kategori = ComboBoxKejadian.Text,
        .Deskripsi = TextDeskripsiKejadian.Text,
        .FotoPath = currentFotoPath
    }

        Laporan.Add(item)
        ModuleData.AppendToFile(item)


        Dim frm As FrPetugas = CType(Application.OpenForms("FrPetugas"), FrPetugas)
        If frm IsNot Nothing Then
            frm.LoadData()
        End If


        MessageBox.Show("Laporan sudah diterima. Terima kasih.")
        Me.Hide()
        FrLogin.Show()

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Title = "search for image"
        OpenFileDialog1.Filter = "Image File (*.jpg;*.png;*.jpeg)|*.jpg;*.jpeg;*.png"

        Dim picture As String

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then


        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

End Class
