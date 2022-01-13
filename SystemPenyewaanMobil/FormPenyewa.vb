Public Class FormPenyewa
    Dim penyewa As New Penyewa

    Public Shared id As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewPenyewa.DataSource = penyewa.GetDataPenyewaDatabase
    End Sub
    Private Sub FormPenyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah = New Tambah_Penyewa()
        tambah.Show()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Dim ubah = New UbahPenyewa()
        ubah.Show()
    End Sub

    Private Sub DataGridViewPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPenyewa.CellClick
        id = DataGridViewPenyewa.CurrentRow.Index
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapus As New HapusPenyewa
        hapus.Show()
    End Sub
End Class