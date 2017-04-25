Imports Bibliotheque

Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim plat As New Plateau()

        TextBox1.Text = plat.HorsPlateau(CInt(tbPrenom.Text), CInt(TextBox2.Text))
    End Sub

End Class
