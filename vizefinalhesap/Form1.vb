Public Class Form1
    Private Sub lblSonuc_Click(sender As Object, e As EventArgs) Handles lblSonuc.Click

    End Sub

    Private Sub btnHesapla_Click(sender As Object, e As EventArgs) Handles btnHesapla.Click
        Dim vize As Double
        Dim final As Double
        Dim ortalama As Double

        vize = CDbl(txtVize.Text)
        final = CDbl(txtFinal.Text)

        'Not ortalamasını hesapla
        ortalama = (vize * 0.4) + (final * 0.6)

        'Sonucu etikete yazdır
        lblSonuc.Text = "Not ortalamanız: " & ortalama.ToString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtVize_TextChanged(sender As Object, e As EventArgs) Handles txtVize.TextChanged

    End Sub
End Class
