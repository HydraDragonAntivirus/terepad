Public Class Calcu
    Private Sub Calcu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form yüklendiğinde yapılacak işlemler
        lblSonuc.Text = "Sonuç: "
        lstIslemGeçmişi.Items.Clear() ' Geçmişi temizle
    End Sub

    ' Toplama işlemi butonuna tıklandığında
    Private Sub BtnTopla_Click(sender As Object, e As EventArgs) Handles btnTopla.Click
        Hesapla(Function(sayi1, sayi2) sayi1 + sayi2)
    End Sub

    ' Çıkarma işlemi butonuna tıklandığında
    Private Sub BtnCikar_Click(sender As Object, e As EventArgs) Handles btnCikar.Click
        Hesapla(Function(sayi1, sayi2) sayi1 - sayi2)
    End Sub

    ' Çarpma işlemi butonuna tıklandığında
    Private Sub BtnCarp_Click(sender As Object, e As EventArgs) Handles btnCarp.Click
        Hesapla(Function(sayi1, sayi2) sayi1 * sayi2)
    End Sub

    ' Bölme işlemi butonuna tıklandığında
    Private Sub BtnBol_Click(sender As Object, e As EventArgs) Handles btnBol.Click
        Hesapla(Function(sayi1, sayi2)
                    If sayi2 = 0 Then
                        Throw New DivideByZeroException()
                    End If
                    Return sayi1 / sayi2
                End Function)
    End Sub

    ' Genel hesaplama metodu
    Private Sub Hesapla(hesaplamaFunc As Func(Of Double, Double, Double))
        Try
            Dim sayi1 As Double = Convert.ToDouble(txtSayi1.Text)
            Dim sayi2 As Double = Convert.ToDouble(txtSayi2.Text)
            Dim sonuc As Double = hesaplamaFunc(sayi1, sayi2)
            lblSonuc.Text = "Sonuç: " & sonuc.ToString()
            ' İşlem geçmişine ekle
            lstIslemGeçmişi.Items.Add(lblSonuc.Text)
        Catch ex As FormatException
            MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As DivideByZeroException
            MessageBox.Show("Bölme işleminde payda 0 olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
