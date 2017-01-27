Imports mshtml
Imports System.Text
Imports System.Windows.Forms

Public Class Browser
    Private _ie As Object
    Private _html As String
    Private _allElements As mshtml.IHTMLElementCollection

    Sub New()
        _ie = New Object
        _ie = CreateObject("InternetExplorer.Application")
        _ie.Visible = True '''''''
    End Sub

#Region "Answer Questions"
    Public Function IsCodeVisible()

    End Function

#End Region

#Region "Actions"
    Public Sub LoadCMS()
        _ie.Navigate("https://cms.gt.com")
        waitForPageLoad()
    End Sub

    Private Sub waitForPageLoad()
        Do While _ie.Busy Or _ie.ReadyState <> 4
            Threading.Thread.Sleep(500)
        Loop
    End Sub

    Public Sub LoadTimePage()
        Dim tdCollection As Object = _ie.Document.GetElementsByTagName("td")
        For Each element As Object In tdCollection
            If element.GetAttribute("title") = "Time" Then
                element.Children(0).click
                Exit For
            End If
        Next

        waitForPageLoad()

        Dim wc As New Net.WebClient
        Dim bHTML() As Byte = wc.DownloadData(_ie.address) 'bytes of html (not usable yet)
        _html = New UTF8Encoding().GetString(bHTML)
        Dim doc As mshtml.IHTMLDocument2 = New mshtml.HTMLDocument
        doc.clear()
        doc.write(_html)
        _allElements = doc.all
        doc.close()
    End Sub
#End Region

End Class
