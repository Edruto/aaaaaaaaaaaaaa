Imports Bibliotheque

Public Class Accueil
    Private Sub btnOK_Click(sender As Object, e As EventArgs)
        Dim plat As New Plateau()

        TextBox1.Text = plat.HorsPlateau(CInt(tbPrenom.Text), CInt(TextBox2.Text))
    End Sub

End Class
