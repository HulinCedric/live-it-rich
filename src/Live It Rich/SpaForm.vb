Public Class SpaForm

    ' Bouton "New Care"
    '
    Private Sub ButtonCare_NewCare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCare_NewCare.Click

        ' Réinitialiser tous les champs
        '
        TextBoxCare_CareLabel.ResetText()
        TextBoxCare_Description.ResetText()
        TextBoxCare_LastHours.ResetText()
        TextBoxCare_LastMinutes.ResetText()
        TextBoxCare_PriceHT.ResetText()
        TextBoxCare_PriceHTInMenu.ResetText()
        TextBoxCare_PriceTTC.ResetText()
        TextBoxCare_VATRate.ResetText()

        ' Cacher le bouton Modify
        '
        ButtonCare_Modify.Visible = False

        ' Afficher le bouton Create Care
        '
        ButtonCare_CreateCare.Visible = True

        ' Dégriser le bouton "Care Label"
        '
        TextBoxCare_CareLabel.Enabled = True

        'Griser le bouton "Price TTC"
        '
        TextBoxCare_PriceTTC.Enabled = False

        ' Afficher le panel
        '
        PanelCare.Show()

    End Sub

    ' Bouton "Modification of Care"
    '
    Private Sub ButtonCare_ModificationOfCare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCare_ModificationOfCare.Click

        ' Réinitialiser tous les champs
        '
        TextBoxCare_CareLabel.ResetText()
        TextBoxCare_Description.ResetText()
        TextBoxCare_LastHours.ResetText()
        TextBoxCare_LastMinutes.ResetText()
        TextBoxCare_PriceHT.ResetText()
        TextBoxCare_PriceHTInMenu.ResetText()
        TextBoxCare_PriceTTC.ResetText()
        TextBoxCare_VATRate.ResetText()
        TextBoxCare_NbOfPossibleParticipants.ResetText()

        ' Cacher le bouton Create Care
        '
        ButtonCare_CreateCare.Visible = False

        ' Afficher le bouton Modify
        '
        ButtonCare_Modify.Visible = True

        ' Griser le bouton "Care Label"
        '
        TextBoxCare_CareLabel.Enabled = False

        'Griser le bouton "Price TTC"
        '
        TextBoxCare_PriceTTC.Enabled = False

        ' Afficher le panel
        '
        PanelCare.Show()

    End Sub

    '  Gestion de l'affichage des boutons en fonction du click
    '
    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCare_CareLabel.TextChanged, _
                                                                                                        TextBoxCare_Description.TextChanged, _
                                                                                                        TextBoxCare_LastHours.TextChanged, _
 _
                                                                                                        TextBoxCare_PriceHT.TextChanged, _
                                                                                                        TextBoxCare_PriceHTInMenu.TextChanged, _
                                                                                                        TextBoxCare_PriceTTC.TextChanged, _
                                                                                                        TextBoxCare_VATRate.TextChanged, _
                                                                                                        TextBoxCare_NbOfPossibleParticipants.TextChanged

        ' Si tous les champs sont remplis on affiche le bouton "Create Care" ou "Modify"
        '
        If (ButtonCare_CreateCare.Visible.Equals(True) _
            And TextBoxCare_CareLabel.TextLength <> 0 _
            And TextBoxCare_PriceHTInMenu.TextLength <> 0 _
            And TextBoxCare_Description.TextLength <> 0 _
            And TextBoxCare_LastHours.TextLength <> 0 _
            And TextBoxCare_LastMinutes.TextLength <> 0 _
            And TextBoxCare_PriceHT.TextLength <> 0 _
            And TextBoxCare_NbOfPossibleParticipants.TextLength <> 0 _
            And TextBoxCare_VATRate.TextLength <> 0) Then

            ButtonCare_CreateCare.Enabled = True

        ElseIf (ButtonCare_Modify.Visible.Equals(True) _
                And TextBoxCare_Description.TextLength <> 0 _
                And TextBoxCare_LastHours.TextLength <> 0 _
                And TextBoxCare_LastMinutes.TextLength <> 0 _
                And TextBoxCare_PriceHT.TextLength <> 0 _
                And TextBoxCare_PriceHTInMenu.TextLength <> 0 _
                And TextBoxCare_NbOfPossibleParticipants.TextLength <> 0 _
                And TextBoxCare_VATRate.TextLength <> 0) Then

            ButtonCare_Modify.Enabled = True

        Else
            ButtonCare_CreateCare.Enabled = False
            ButtonCare_Modify.Enabled = False
        End If

    End Sub

    Private Sub ButtonCareMenu_NewCareMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCareMenu_NewCareMenu.Click

        ' Réinitialiser tous les champs
        '
        TextBoxCareMenu_CareMenuLabel.ResetText()
        TextBoxCareMenu_Description.ResetText()
        TextBoxCareMenu_LastHours.ResetText()
        TextBoxCareMenu_LastMinutes.ResetText()
        TextBoxCareMenu_PriceHT.ResetText()
        TextBoxCareMenu_NumberOfCares.ResetText()
        TextBoxCareMenu_PriceTTC.ResetText()
        TextBoxCareMenu_VATRate.ResetText()

        ' Cacher le bouton Modify
        '
        ButtonCareMenu_Modify.Visible = False

        ' Afficher le bouton Create Care
        '
        ButtonCareMenu_CreateCareMenu.Visible = True

        ' Dégriser le bouton "Care Label"
        '
        TextBoxCareMenu_CareMenuLabel.Enabled = True

        'Griser le bouton "Price TTC"
        '
        TextBoxCareMenu_PriceTTC.Enabled = False

        ' Afficher le panel
        '
        PanelCareMenu.Show()
    End Sub

    Private Sub PanelListOfBooking_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelListOfBooking.Paint

    End Sub
End Class