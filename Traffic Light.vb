'Date: Feb. 12 2020
'Instructor: Ralph Hunsberger
'Traffic Light
'Description: This project changes the color of each text box by clicking the tab key.

Option Explicit On
Public Class frmTrafficLight
    Private Sub txtGreenLight_GotFocus(sender As Object, e As EventArgs) Handles txtGreenLight.GotFocus
        txtGreenLight.BackColor = Color.Green
    End Sub
    Private Sub txtGreenLight_Leave(sender As Object, e As EventArgs) Handles txtGreenLight.Leave
        txtGreenLight.BackColor = Color.Gray
    End Sub
    Private Sub txtYellowLight_GotFocus(sender As Object, e As EventArgs) Handles txtYellowLight.GotFocus
        txtYellowLight.BackColor = Color.Yellow
    End Sub

    Private Sub txtYellowLight_Leave(sender As Object, e As EventArgs) Handles txtYellowLight.Leave
        txtYellowLight.BackColor = Color.Gray
    End Sub
    Private Sub txtRedLight_GotFocus(sender As Object, e As EventArgs) Handles txtRedLight.GotFocus
        txtRedLight.BackColor = Color.Red
    End Sub

    Private Sub txtRedLight_Leave(sender As Object, e As EventArgs) Handles txtRedLight.Leave
        txtRedLight.BackColor = Color.Gray
    End Sub
End Class
