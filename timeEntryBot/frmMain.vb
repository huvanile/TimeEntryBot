Imports System.Xml
Imports timeEntryBot.Helpers
Imports timeEntryBot.DataValidationHelpers
Imports timeEntryBot.Models
Imports timeEntryBot.Globals
Imports timeEntryBot.RegistryHelpers

Public Class FrmMain
    Public XmlFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\TimeEntryBot\"
    Public XmlFileName As String = "Engagements.xml"

#Region "Form-wide Actions"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddressNulls()
        GetPrefs()
        loadPrefs()

        lblUserMessages.Visible = False
        txtHours.Text = 8 'Default to 8 hours

        '''''''TESTING 
        'txtName.Text = "TEST"
        'txtClient.Text = "123456"
        'txtAssgn.Text = "1234"
        'txtHours.Text = "3"
        'txtLocation.Text = "123"
        '''''''TESTING

        'Load saved engagement combo box
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
            txtUser.Text = Username
            txtPass.Text = Password
            txtName.Text = AliasName

        Catch exAll As Exception
            Debug.Print("CAUGHT ERROR IN loadPrefs: " & exAll.Message)
            MsgBox("An error has occurred when loading the bot's preferences.  Please close and reopen this bot and try again.", vbCritical, TITLE & " v" & VERSION)
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
                .SetValue(REGISTRYFOLDER, "Username", txtUser.Text)
                .SetValue(REGISTRYFOLDER, "Password", txtPass.Text)
                .SetValue(REGISTRYFOLDER, "AliasName", txtName.Text)
            End With

        Catch exAll As Exception
            Debug.Print("CAUGHT ERROR IN savePrefs: " & exAll.Message)
            MsgBox("An error has occurred when saving the bot's preferences.  Please close and reopen this bot and try again.", vbCritical, TITLE & " v" & VERSION)
        End Try

    End Sub
#End Region

    Private Sub btnNow_Click(sender As Object, e As EventArgs) Handles btnNow.Click
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
            browser.LoadTimePage()
            If Not browser.IsCodeVisible Then
                '
            End If
        End If
    End Sub

    Private Sub btnScheduled_Click(sender As Object, e As EventArgs) Handles btnScheduled.Click
        savePrefs()
        GetPrefs()
        Throw New NotImplementedException
    End Sub

    Private Sub btn_SaveClient_Click(sender As Object, e As EventArgs) Handles btn_SaveClient.Click
        savePrefs()
        GetPrefs()
        Dim eng As New Engagement(txtName.Text, txtClient.Text, txtAssgn.Text, txtHours.Text, txtLocation.Text)

        XmlHelper.WriteXmlFile(XmlFilePath, XmlFileName, eng)
        lblUserMessages.Visible = True
        lblUserMessages.Text = "Client Code Saved"
        'Load saved engagement combo box
        LoadSavedCodeList()
    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        Dim selectedName As String = txtName.Text
        XmlHelper.DeleteEngagementNodeByName(XmlFilePath, XmlFileName, selectedName)
        lblUserMessages.Text = "Client Code Deleted"
        'Load saved engagement combo box
        LoadSavedCodeList()
        ClearEngagementBoxes()
    End Sub

    Private Sub ClearEngagementBoxes()
        txtName.Text = ""
        txtClient.Text = ""
        txtAssgn.Text = ""
        txtHours.Text = ""
        txtLocation.Text = ""
    End Sub



#Region "Combobox"
    Private Sub LoadSavedCodeList()
        'Clear the old list so we can rebuild it
        cmbSavedCodeList.Items.Clear()

        'Now loop through the XML to build the list again
        Dim xmlNodeList As IEnumerable = XmlHelper.ReadElementsFromFile(XmlFilePath, XmlFileName)
        For Each nNode As XmlNode In xmlNodeList
            ''-For Each nChildNode As XmlNode In nNode.ChildNodes
            cmbSavedCodeList.Items.Add(nNode.Attributes(0).InnerText)
            ''Next
        Next
    End Sub

    Private Sub cmbSavedCodeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSavedCodeList.SelectedIndexChanged
        Dim selectedName As String = cmbSavedCodeList.SelectedItem
        LoadAssignmentInformation(selectedName)
        lblUserMessages.Visible = True
        lblUserMessages.Text = "Saved Client Code Loaded"
    End Sub

    Private Sub LoadAssignmentInformation(selectedName As String)
        Dim eng As Engagement = XmlHelper.FindEngagementNodeByName(XmlFilePath, XmlFileName, selectedName)
        txtName.Text = eng.Name
        txtClient.Text = eng.ClientCode
        txtAssgn.Text = eng.AssignmentCode
        txtHours.Text = eng.HoursPerDay
        txtLocation.Text = eng.Location
    End Sub
#End Region

End Class