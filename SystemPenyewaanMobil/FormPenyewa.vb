Public Class FormPenyewa
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah = New Tambah_Penyewa()
        tambah.Show()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim ubah = New UbahPenyewa()
        ubah.Show()
    End Sub
End Class