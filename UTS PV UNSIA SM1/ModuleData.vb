Module ModuleData

    Public Laporan As New List(Of LaporanItem)

    Public Class LaporanItem
        Public Property Nama As String
        Public Property NoHP As String
        Public Property Alamat As String
        Public Property Kategori As String
        Public Property Deskripsi As String
        Public Property FotoPath As String

    End Class


    Public ReadOnly FilePath As String = IO.Path.Combine(Application.StartupPath, "laporan.csv")


    Private Function EscapeField(s As String) As String
        If s Is Nothing Then Return ""
        Return s.Replace(";", "﹔").Replace(vbCr, " ").Replace(vbLf, " ").Replace(Environment.NewLine, " ")
    End Function


    Public Sub AppendToFile(item As LaporanItem)
        Try
            Dim line As String = String.Join(";", New String() {
    EscapeField(item.Nama),
    EscapeField(item.NoHP),
    EscapeField(item.Alamat),
    EscapeField(item.Kategori),
    EscapeField(item.Deskripsi),
    EscapeField(item.FotoPath)
})
            IO.File.AppendAllText(FilePath, line & Environment.NewLine)
        Catch ex As Exception

        End Try
    End Sub


    Public Sub LoadFromFile()
        Try
            Laporan.Clear()
            If Not IO.File.Exists(FilePath) Then Return

            Dim lines = IO.File.ReadAllLines(FilePath)
            For Each l In lines
                If String.IsNullOrWhiteSpace(l) Then Continue For
                Dim parts = l.Split(";"c)
                If parts.Length >= 6 Then
                    Dim it As New LaporanItem With {
        .Nama = parts(0).Replace("﹔", ";"),
        .NoHP = parts(1).Replace("﹔", ";"),
        .Alamat = parts(2).Replace("﹔", ";"),
        .Kategori = parts(3).Replace("﹔", ";"),
        .Deskripsi = parts(4).Replace("﹔", ";"),
        .FotoPath = parts(5).Replace("﹔", ";")
    }
                    Laporan.Add(it)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

End Module
