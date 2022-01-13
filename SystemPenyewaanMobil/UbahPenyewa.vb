Public Class UbahPenyewa
    Public Shared penyewa As New Penyewa
    Public Shared id As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = FormPenyewa.id
        TxtNIK.Text = FormPenyewa.DataGridViewPenyewa(1, id).Value
        TxtNama.Text = FormPenyewa.DataGridViewPenyewa(2, id).Value
        RtxAlamat.Text = FormPenyewa.DataGridViewPenyewa(3, id).Value

    End Sub
    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only!")
        End If
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        penyewa.GSNamaPenyewa = TxtNama.Text
        penyewa.GSNikPenyewa = TxtNIK.Text
        penyewa.GSAlamatPenyewa = RtxAlamat.Text

        Dim info As New Info_UbahPenyewa()
        info.Show()
        Me.Close()
    End Sub
End Class