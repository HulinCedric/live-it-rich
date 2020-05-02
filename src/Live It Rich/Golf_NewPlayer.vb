Public Class Golf_NewPlayer

    ' Fonction permettant de cacher le bouton "Create Player" si les champs sont vide
    '
    Private Sub TextBoxNewPlayer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNewPlayer_Name.TextChanged, TextBoxNewPlayer_Surname.TextChanged
        If (TextBoxNewPlayer_Name.TextLength <> 0 _
            And TextBoxNewPlayer_Surname.TextLength <> 0) Then

            ButtonNewPlayer_CreatePlayer.Enabled = True
        Else
            ButtonNewPlayer_CreatePlayer.Enabled = False
        End If
    End Sub
End Class