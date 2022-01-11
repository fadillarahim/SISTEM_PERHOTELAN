Public Class TAMBAH_JENIS_KAMAR
    Private Sub BtnTambahJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisKamar.Click

        JENIS_KAMAR.jenisKamar.jenisKamarProperty = TxtJenisKamar.Text.ToString()
        JENIS_KAMAR.jenisKamar.hargaPermalamProperty = Double.Parse(TxtHargaKamarPermalam.Text)

        JENIS_KAMAR.jenisKamar.AddDataJenisKamarDatabase(JENIS_KAMAR.jenisKamar.jenisKamarProperty,
                                                        JENIS_KAMAR.jenisKamar.hargaPermalamProperty)


        Me.Close()
    End Sub

    Private Sub TxtJenisKamar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJenisKamar.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan text")
        End If
    End Sub

    Private Sub TxtHargaKamarPermalam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaKamarPermalam.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukan angka")
        End If
    End Sub

End Class