Imports System.IO

Public Class DataValidationHelpers

    Public Shared Sub checkForNumber(theControl As Control, theMin As Int16, theMax As Integer)
        If theControl.Text = "" Or Not IsNumeric(theControl.Text) Then
            Globals.Proceed = False
            theControl.ForeColor = Color.White
            theControl.BackColor = Color.Red
        Else
            If theControl.Text < theMin Or theControl.Text > theMax Then
                Globals.Proceed = False
                theControl.ForeColor = Color.White
                theControl.BackColor = Color.Red
            Else
                theControl.ForeColor = Color.Black
                theControl.BackColor = Color.White
            End If
        End If
        theControl.Refresh()
    End Sub

    Public Shared Sub checkForText(theControl As Control)
        If theControl.Text = "" Then
            Globals.Proceed = False
            theControl.ForeColor = Color.White
            theControl.BackColor = Color.Red
        Else
            theControl.ForeColor = Color.Black
            theControl.BackColor = Color.White
        End If
        theControl.Refresh()
    End Sub
End Class
