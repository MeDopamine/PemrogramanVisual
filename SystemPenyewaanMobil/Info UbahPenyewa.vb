Public Class Info_UbahPenyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbNama.Text = UbahPenyewa.penyewa.GSNamaPenyewa
        LbNIK.Text = UbahPenyewa.penyewa.GSNikPenyewa
        LbAlamat.Text = UbahPenyewa.penyewa.GSAlamatPenyewa
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        UbahPenyewa.penyewa.UpdatePenyewaDatabase(UbahPenyewa.id, UbahPenyewa.penyewa.GSNamaPenyewa,
                                      UbahPenyewa.penyewa.GSNikPenyewa, UbahPenyewa.penyewa.GSAlamatPenyewa)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class