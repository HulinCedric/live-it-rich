Public Class RestaurantForm

    Private Sub OrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimeShow.Text = Format(Now(), "hh:mm:ss")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimeShow.Text = Format(Now(), "hh:mm:ss")
    End Sub
End Class