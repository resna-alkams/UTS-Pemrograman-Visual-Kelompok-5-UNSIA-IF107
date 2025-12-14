Public Class FrPetugas


    Private Sub FrPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupGrid()
        LoadData()
    End Sub

    Private Sub SetupGrid()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns.Clear()


        Dim colNama As New DataGridViewTextBoxColumn()
        colNama.Name = "colNama"
        colNama.HeaderText = "Nama"
        DataGridView1.Columns.Add(colNama)

        Dim colWA As New DataGridViewTextBoxColumn()
        colWA.Name = "colWA"
        colWA.HeaderText = "No WA"
        DataGridView1.Columns.Add(colWA)

        Dim colAlamat As New DataGridViewTextBoxColumn()
        colAlamat.Name = "colAlamat"
        colAlamat.HeaderText = "Alamat"
        DataGridView1.Columns.Add(colAlamat)

        Dim colKategori As New DataGridViewTextBoxColumn()
        colKategori.Name = "colKategori"
        colKategori.HeaderText = "Kategori"
        DataGridView1.Columns.Add(colKategori)

        Dim colDeskripsi As New DataGridViewTextBoxColumn()
        colDeskripsi.Name = "colDeskripsi"
        colDeskripsi.HeaderText = "Deskripsi"
        DataGridView1.Columns.Add(colDeskripsi)


        Dim imgCol As New DataGridViewImageColumn()
        imgCol.Name = "colFoto"
        imgCol.HeaderText = "Foto"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridView1.Columns.Add(imgCol)

        DataGridView1.RowTemplate.Height = 80
        DataGridView1.AllowUserToAddRows = False
    End Sub

    Public Sub LoadData()

        DataGridView1.Rows.Clear()

        For Each item In ModuleData.Laporan
            Dim idx = DataGridView1.Rows.Add()
            DataGridView1.Rows(idx).Cells("colNama").Value = item.Nama
            DataGridView1.Rows(idx).Cells("colWA").Value = item.NoHP
            DataGridView1.Rows(idx).Cells("colAlamat").Value = item.Alamat
            DataGridView1.Rows(idx).Cells("colKategori").Value = item.Kategori
            DataGridView1.Rows(idx).Cells("colDeskripsi").Value = item.Deskripsi

            If Not String.IsNullOrEmpty(item.FotoPath) AndAlso IO.File.Exists(item.FotoPath) Then
                Try
                    Using fs = IO.File.OpenRead(item.FotoPath)
                        Dim img = Image.FromStream(fs)

                        DataGridView1.Rows(idx).Cells("colFoto").Value = New Bitmap(img, 80, 80)
                    End Using
                Catch ex As Exception

                    DataGridView1.Rows(idx).Cells("colFoto").Value = Nothing
                End Try
            Else
                DataGridView1.Rows(idx).Cells("colFoto").Value = Nothing
            End If
            Label1.Text = "Jumlah Laporan: " & DataGridView1.Rows.Count

        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModuleData.LoadFromFile()
        LoadData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
