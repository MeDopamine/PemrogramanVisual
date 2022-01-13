Public Class HapusPenyewa
    Private penyewa As New Penyewa
    Dim id As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = FormPenyewa.id
        LbNIK.Text = FormPenyewa.DataGridViewPenyewa(1, id).Value
        LbNama.Text = FormPenyewa.DataGridViewPenyewa(2, id).Value
        LbAlamat.Text = FormPenyewa.DataGridViewPenyewa(3, id).Value
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        penyewa.RemoveDataPenyewaDatabase(id)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class