Imports timeEntryBot.Helpers.CMSHelpers

Public Class Browser
    Private _ie As SHDocVw.InternetExplorer
    Private _periodStart As String
    Private _periodEnd As String
    Private _timeKeeperUno As String
    Private _todayDate As String
    Private _tgIFrameDoc As mshtml.IHTMLDocument2
    Private _codeAlreadyPresent As Boolean

#Region "Contstructors"
    Sub New()
        _ie = Nothing
        _tgIFrameDoc = Nothing
        _timeKeeperUno = ""
        _todayDate = Format(Date.Now(), "yyyy-MM-dd")
        _periodEnd = getPeriodEnd()
        _periodStart = getPeriodStart()
        _ie = CreateObject("InternetExplorer.Application")
        _ie.Visible = True '''''''
    End Sub
#End Region

#Region "Properties"

    ''' <summary>
    ''' determines if the assgn and client code the user specified is already present in the site
    ''' </summary>
    ''' <returns>boolean</returns>
    Public ReadOnly Property CodeAlreadyPresent As Boolean
        Get
            Return _codeAlreadyPresent
        End Get
    End Property

    ''' <summary>
    ''' CMS has a separate ID for each user that doesn't match the domain user ID
    ''' We need to grab this ID for future use
    ''' </summary>
    ''' <returns>CMS's "timekeeperuno" field for the user</returns>
    Public ReadOnly Property TimeKeeperUno As String
        Get
            Return _timeKeeperUno
        End Get
    End Property
#End Region

#Region "Actions"
    Public Sub LoadCMS()
        _ie.Navigate("https://cms.gt.com")
        waitForPageLoad()
    End Sub

    Private Sub waitForPageLoad()
        Threading.Thread.Sleep(1000)
        Do While _ie.Busy Or _ie.ReadyState <> 4
            Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Public Sub LoadTimePages()
        _ie.Navigate("https://cms.gt.com/cmsnet/time/architecture/multiviewshell.aspx?Host=CMSNET")

        waitForPageLoad()

        _timeKeeperUno = getTimeKeeperUno(_ie.Document.body.outerhtml)

        Dim mvfsIFrameDoc As mshtml.IHTMLDocument2 = _ie.Document.getElementsbyTagName("iframe")(0).contentWindow.document 'iframe containing multiviewframeset.ASPX

        'navigate to teh correct week if needed (gridview contains the week heading and nav buttons)
        If mvfsIFrameDoc.getelementsbyTagName("frame")(0).src.ToString <> "../gridview/gridview.aspx?Host=CMSNET&periodTarget=" & getPeriodStart() & "&timeKeeperUno=" & _timeKeeperUno & "&todayDate=" & Format(Date.Now(), "yyyy-MM-dd") Then
            mvfsIFrameDoc.getelementsbyTagName("frame")(0).navigate("https://cms.gt.com/cmsnet/time/gridview/gridview.aspx?Host=CMSNET&periodTarget=" & getPeriodStart() & "&timeKeeperUno=" & _timeKeeperUno & "&todayDate=" & Format(Date.Now(), "yyyy-MM-dd"))
            waitForPageLoad()
        End If

        Dim gvFrameDoc As mshtml.IHTMLDocument2 = mvfsIFrameDoc.getelementsbyTagName("frame")(0).contentwindow.document 'first frame in multiviewframeset, contains gridview

        'the tgIFrameDoc is where the actual client names and time entries are 
        waitForPageLoad()
        _tgIFrameDoc = gvFrameDoc.getelementsbyTagName("iframe")(0).contentwindow.document 'first iframe in gridview, contains timegrid

        If IsCodeVisible(_tgIFrameDoc.body.outerHTML) Then _codeAlreadyPresent = True Else _codeAlreadyPresent = False

    End Sub

    Public Sub EnterTimeForWeek()
        For x As Short = 1 To 5
            waitForPageLoad()
            EnterTimeForDay(Format(CDate(_periodStart).AddDays(x), "MM/dd/yyyy"))
        Next x
    End Sub

    Private Sub EnterTimeForDay(theDay As String)
        _ie.Document.getelementbyid("NewTimeEntry_Image").click
        waitForPageLoad()
        Dim mvfsIFrameDoc As mshtml.IHTMLDocument2 = _ie.Document.getElementsbyTagName("iframe")(0).contentWindow.document 'iframe containing multiviewframeset.ASPX
        Dim mvdFrameDoc As mshtml.IHTMLDocument2 = mvfsIFrameDoc.getelementsbytagname("frame")(1).contentwindow.document 'frame containing multiViewDetail.aspx
        Dim bIframeDoc As mshtml.IHTMLDocument2 = mvdFrameDoc.getelementsbytagname("iframe")(0).contentwindow.document 'frame containing blank.htm
        With bIframeDoc
            .getelementbyid("TimeFormControl_ClientCode_TEXTClientCode_Input").value = Globals.ClientCode
            .getelementbyid("TimeFormControl_MatterCode_TEXTMatterCode_Input").value = Globals.AssgnCode
            .getelementbyid("TimeFormControl_TransactionDate_TEXTTransactionDate_Input").value = theDay
            .getelementbyid("TimeFormControl_BaseHours_TEXTBaseHours").value = Globals.Hours
            .getelementbyid("NarrativeTextBox").value = "Entered by TimeBot"

            'this works, but need to add to it to check for the right location code. right now it just grabs the top one in the drop-down.
            .getelementbyid("TimeFormControl_LocationCode_TEXTLocationCode_Image_Image").click : Threading.Thread.Sleep(1000)
            SendKeys.Send("{DOWN}") : Threading.Thread.Sleep(1000)
            SendKeys.Send("{ENTER}") : Threading.Thread.Sleep(1000)

            .getelementbyid("SubmitButton").click() : Threading.Thread.Sleep(1000)
            waitForPageLoad()
        End With
        mvfsIFrameDoc = Nothing
        mvdFrameDoc = Nothing
        bIframeDoc = Nothing
    End Sub
#End Region

End Class
