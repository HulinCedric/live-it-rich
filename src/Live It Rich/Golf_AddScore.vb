Public Class Golf_AddScore

    ' Fonction permettant de cacher le bouton "Add Score" si les champs sont vide
    '
    Private Sub TextBoxAddScore_Score_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAddScore_Score.TextChanged
        If TextBoxAddScore_Score.TextLength <> 0 Then
            ButtonAddScore.Enabled = True
        Else
            ButtonAddScore.Enabled = False
        End If
    End Sub

End Class