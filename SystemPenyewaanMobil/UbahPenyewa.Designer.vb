﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahPenyewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.RtxAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(105, 77)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(227, 20)
        Me.TxtNama.TabIndex = 0
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(105, 113)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(227, 20)
        Me.TxtNIK.TabIndex = 1
        '
        'RtxAlamat
        '
        Me.RtxAlamat.Location = New System.Drawing.Point(105, 152)
        Me.RtxAlamat.Name = "RtxAlamat"
        Me.RtxAlamat.Size = New System.Drawing.Size(227, 96)
        Me.RtxAlamat.TabIndex = 2
        Me.RtxAlamat.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ubah Data Penyewa"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(257, 254)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 13
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'UbahPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 297)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RtxAlamat)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.TxtNama)
        Me.Name = "UbahPenyewa"
        Me.Text = "UbahPenyewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents RtxAlamat As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSimpan As Button
End Class