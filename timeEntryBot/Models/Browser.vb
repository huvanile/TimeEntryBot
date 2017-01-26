Imports System.Windows.Forms

Public Class Browser
    Private ie As Object

    Sub New()
        ie = New Object
        ie = CreateObject("InternetExplorer.Application")
        ie.Visible = True '''''''
    End Sub

#Region "Answer Questions"
    Public Function IsCodeVisible()

    End Function
#End Region

#Region "Actions"
    Public Sub LoadCMS()
        ie.Navigate("https://cms.gt.com")
        waitForPageLoad()
    End Sub

    Private Sub waitForPageLoad()
        Do While ie.Busy Or ie.ReadyState <> 4
            Threading.Thread.Sleep(500)
        Loop
    End Sub

    Public Sub LoadTimePage()
        Dim tdCollection As Object = ie.Document.GetElementsByTagName("td")
        For Each element As Object In tdCollection
            If element.GetAttribute("title") = "Time" Then
                element.Children(0).click
                Exit For
            End If
        Next
        waitForPageLoad()
    End Sub
#End Region

End Class
