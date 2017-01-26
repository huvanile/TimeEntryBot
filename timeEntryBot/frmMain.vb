Public Class frmMain

    Private Sub btnNow_Click(sender As Object, e As EventArgs) Handles btnNow.Click
        Dim browser As New Browser
        browser.LoadCMS()
        browser.LoadTimePage()
        If Not browser.IsCodeVisible Then
            '
        End If
    End Sub

    Private Sub btnScheduled_Click(sender As Object, e As EventArgs) Handles btnScheduled.Click

    End Sub
End Class