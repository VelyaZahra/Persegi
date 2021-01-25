Public Class Form1
    Private P As New persegi
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        P.Panjang = CDec(txtPanjang.Text)
        P.Lebar = CDec(txtLebar.Text)
        txtLuas.Text = P.Luas()
        txtKeliling.Text = P.Keliling()
    End Sub
End Class
