Public Class HomeForm

    Private Sub HomeForm_Quit(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        QuitDialog.ShowDialog()
        If QuitDialog.DialogResult = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
        QuitDialog.Close()
    End Sub

    Private Sub ButtonReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReservation.Click
        ReservationForm.Show()
    End Sub

    

    Private Sub ButtonComplain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonComplain.Click
        ComplainForm.Show()
    End Sub

    Private Sub ButtonStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStock.Click
        StockForm.Show()
    End Sub

    Private Sub ButtonGolf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGolf.Click
        GolfForm.Show()
    End Sub

    Private Sub ButtonRestaurant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRestaurant.Click
        RestaurantForm.Show()
    End Sub

    Private Sub ButtonBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBilling.Click
        BillingForm.Show()
    End Sub

    Private Sub ButtonCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalendar.Click
        CalendarForm.Show()
    End Sub

    Private Sub ButtonStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStaff.Click
        StaffForm.Show()
    End Sub

End Class