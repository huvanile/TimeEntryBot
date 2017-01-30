Imports System.Xml
Imports System.Environment
Imports timeEntryBot.Helpers.XmlHelper
Imports timeEntryBot.DataValidationHelpers
Imports timeEntryBot.Models
Imports timeEntryBot.Globals
Imports timeEntryBot.RegistryHelpers

Public Class FrmMain
    Public XmlFilePath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\TimeEntryBot"
    Public XmlFileName As String = "Engagements.xml"

#Region "Form-wide Actions"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddressNulls()
        GetPrefs()
        loadPrefs()
        CreateFirstEngagement()
        LoadSavedCodeList()
    End Sub

    Private Sub notifyIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles notifyIcon.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        Me.notifyIcon.Visible = False
    End Sub

    Private Sub frmMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = False
            notifyIcon.Visible = True
            notifyIcon.ShowBalloonTip(4000)
        End If
    End Sub

#End Region

#Region "Thread-safe GUI Updaters"
    Public Delegate Sub setStatusSafeCallback([theText] As String)

    Private Sub setStatusSafe([theText] As String)
        Try
            If mainStatus.InvokeRequired Then
                Dim d As New setStatusSafeCallback(AddressOf setStatusSafe)
                Invoke(d, New Object() {[theText]})
                d = Nothing
            Else
                statusLabel.Text = theText
                mainStatus.Refresh()
            End If
        Catch exAll As Exception : End Try
    End Sub
#End Region

#Region "Registry"
    'hadda put this stuff here instead of the registryHelpers bc couldn't figure out any other way

    ''' <summary>
    ''' This populates the GUI with registry values
    ''' </summary>
    Private Sub loadPrefs()
        Try

            'textboxes
            txtClient.Text = ClientCode
            txtAssgn.Text = AssgnCode
            txtLocation.Text = LocationCode
            txtHours.Text = Hours
            txtURL.Text = SiteURL
            txtUser.Text = UserN
            txtPass.Text = Password
            txtName.Text = AliasName

        Catch exAll As Exception
            Debug.Print("CAUGHT ERROR IN loadPrefs: " & exAll.Message)
            MsgBox("An error has occurred when loading the bot's preferences.  Please close and reopen this bot and try again.", vbCritical, TITLE & " v" & Globals.VERSION)
        End Try
    End Sub

    Private Sub savePrefs()
        Try

            With My.Computer.Registry

                'other
                .SetValue(REGISTRYFOLDER, "ClientCode", txtClient.Text)
                .SetValue(REGISTRYFOLDER, "AssgnCode", txtAssgn.Text)
                .SetValue(REGISTRYFOLDER, "LocationCode", txtLocation.Text)
                .SetValue(REGISTRYFOLDER, "Hours", txtHours.Text)
                .SetValue(REGISTRYFOLDER, "SiteURL", txtURL.Text)
                .SetValue(REGISTRYFOLDER, "UserN", txtUser.Text)
                .SetValue(REGISTRYFOLDER, "Password", txtPass.Text)
                .SetValue(REGISTRYFOLDER, "AliasName", txtName.Text)
            End With

        Catch exAll As Exception
            Debug.Print("CAUGHT ERROR IN savePrefs: " & exAll.Message)
            MsgBox("An error has occurred when saving the bot's preferences.  Please close and reopen this bot and try again.", vbCritical, TITLE & " v" & Globals.VERSION)
        End Try

    End Sub
#End Region

#Region "Click Handlers"
    Private Sub btnNow_Click(sender As Object, e As EventArgs) Handles btnNow.Click
        Proceed = True
        checkForText(txtURL)
        checkForText(txtUser)
        checkForText(txtPass)
        checkForText(txtName)
        checkForText(txtClient)
        checkForText(txtAssgn)
        checkForNumber(txtHours, 1, 16)
        checkForText(txtLocation)
        If Proceed Then
            savePrefs()
            GetPrefs()
            Dim browser As New Browser
            browser.LoadCMS()
            browser.LoadTimePages()
            setStatusSafe("Entering hours for engagement")
            browser.EnterTimeForWeek()
        Else
        End If
    End Sub

    Private Sub btnScheduled_Click(sender As Object, e As EventArgs) Handles btnScheduled.Click
        Proceed = True
        checkForText(txtURL)
        checkForText(txtUser)
        checkForText(txtPass)
        checkForText(txtName)
        checkForText(txtClient)
        checkForText(txtAssgn)
        checkForNumber(txtHours, 1, 16)
        checkForText(txtLocation)
        If Proceed Then
            savePrefs()
            GetPrefs()
            Throw New NotImplementedException
        End If
    End Sub

    Private Sub btn_SaveClient_Click(sender As Object, e As EventArgs) Handles btn_SaveClient.Click
        savePrefs()
        GetPrefs()
        Dim eng As New Engagement(txtName.Text, txtClient.Text, txtAssgn.Text, txtHours.Text, txtLocation.Text)
        WriteXmlFile(XmlFilePath, XmlFileName, eng)
        setStatusSafe("Client Code Saved")
        LoadSavedCodeList() 'Load saved engagement combo box
    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        Dim selectedName As String = txtName.Text
        DeleteEngagementNodeByName(XmlFilePath, XmlFileName, selectedName)
        setStatusSafe("Client Code Deleted")
        LoadSavedCodeList() 'Load saved engagement combo box
        ClearEngagementBoxes()
    End Sub
#End Region

#Region "Engagement Combobox"

    ''' <summary>
    ''' This creates the user's first engagement based on default values, to prevent errors on first load of the tool
    ''' </summary>
    Private Sub CreateFirstEngagement()
        If Not IO.Directory.Exists(XmlFilePath) Then MkDir(XmlFilePath)
        Dim engagement As New Engagement(txtName.Text, txtClient.Text, txtAssgn.Text, txtHours.Text, txtLocation.Text)
        WriteXmlFile(XmlFilePath, XmlFileName, engagement)
        LoadSavedCodeList()
        cmbSavedCodeList.Text = cmbSavedCodeList.Items(0).ToString
        setStatusSafe("")
    End Sub

    Private Sub ClearEngagementBoxes()
        txtName.Text = ""
        txtClient.Text = ""
        txtAssgn.Text = ""
        txtHours.Text = ""
        txtLocation.Text = ""
        cmbSavedCodeList.Text = String.Empty
    End Sub
    Private Sub LoadSavedCodeList()
        cmbSavedCodeList.Items.Clear() 'Clear the old list so we can rebuild it
        Dim xmlNodeList As IEnumerable = ReadElementsFromFile(XmlFilePath, XmlFileName)
        For Each nNode As XmlNode In xmlNodeList 'Now loop through the XML to build the list again
            cmbSavedCodeList.Items.Add(nNode.Attributes(0).InnerText)
        Next
    End Sub

    Private Sub cmbSavedCodeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSavedCodeList.SelectedIndexChanged
        Dim selectedName As String = cmbSavedCodeList.SelectedItem
        LoadAssignmentInformation(selectedName)
        setStatusSafe("Saved Client Code Loaded")
    End Sub

    Private Sub LoadAssignmentInformation(selectedName As String)
        Dim eng As Engagement = FindEngagementNodeByName(XmlFilePath, XmlFileName, selectedName)
        txtName.Text = eng.Name
        txtClient.Text = eng.ClientCode
        txtAssgn.Text = eng.AssignmentCode
        txtHours.Text = eng.HoursPerDay
        txtLocation.Text = eng.Location
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Proceed = True
        checkForText(txtURL)
        checkForText(txtUser)
        checkForText(txtPass)
        If Proceed Then
            savePrefs()
            GetPrefs()
            setStatusSafe("Time Site Settings Saved")
        End If
    End Sub

#End Region

End Class