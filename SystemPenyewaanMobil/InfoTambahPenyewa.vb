﻿Public Class InfoTambahPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbNama.Text = Tambah_Penyewa.penyewa.GSNamaPenyewa
        LbNIK.Text = Tambah_Penyewa.penyewa.GSNikPenyewa
        LbAlamat.Text = Tambah_Penyewa.penyewa.GSAlamatPenyewa
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Tambah_Penyewa.penyewa.AddPenyewaDatabase(Tambah_Penyewa.penyewa.GSNamaPenyewa, Tambah_Penyewa.penyewa.GSNikPenyewa, Tambah_Penyewa.penyewa.GSAlamatPenyewa)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class