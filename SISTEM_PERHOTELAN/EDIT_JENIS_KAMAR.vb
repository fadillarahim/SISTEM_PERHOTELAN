Public Class EDIT_JENIS_KAMAR

    Public Sub New()

        ' this call is required by the designer.
        InitializeComponent()

        ' add any initialization after the initializecomponent() call.

        TxtJenisKamar.Text = JENIS_KAMAR.jenisKamar.jenisKamarProperty
        TxtHargaKamarPermalam.Text = JENIS_KAMAR.jenisKamar.hargaPermalamProperty

    End Sub

    Private Sub BtnSimpanJenisKamar_Click(sender As Object, e As EventArgs) Handles BtnSimpanJenisKamar.Click

        JENIS_KAMAR.jenisKamar.jenisKamarProperty = TxtJenisKamar.Text.ToString()
        JENIS_KAMAR.jenisKamar.hargaPermalamProperty = Double.Parse(TxtHargaKamarPermalam.Text)

        JENIS_KAMAR.jenisKamar.UpdateDataJenisKamarByIDDatabase(JENIS_KAMAR.selectedtablejeniskamar,
                                                                JENIS_KAMAR.jenisKamar.jenisKamarProperty,
                                                                JENIS_KAMAR.jenisKamar.hargaPermalamProperty)
        JENIS_KAMAR.Show()
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
            MessageBox.Show("Mohon Hanya mengisikan Angka!!!")
        End If
    End Sub
End Class