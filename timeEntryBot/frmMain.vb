Imports System.Collections.ObjectModel
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml
Imports timeEntryBot.Helpers
Imports timeEntryBot.Models

Public Class FrmMain
    Public XmlFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\TimeEntryBot\"
    Public XmlFileName As String = "Engagements.xml"

    Private Sub btnNow_Click(sender As Object, e As EventArgs) Handles btnNow.Click
        Dim browser As New Browser
        browser.LoadCMS()
        browser.LoadTimePage()
        If Not browser.IsCodeVisible Then
            '
        End If
    End Sub

    Private Sub btnScheduled_Click(sender As Object, e As EventArgs) Handles btnScheduled.Click
        Throw New NotImplementedException
    End Sub

    Private Sub btn_SaveClient_Click(sender As Object, e As EventArgs) Handles btn_SaveClient.Click
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtURL.Text = "https://cms.gt.com/"
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

        'IEnumerable engagements = New Engagements
        'Dim engData = new ObservableCollection(Of Engagement)
        'For Each eng As Engagement In engagements
        '    engData.Add(eng)
        'Next
        dgvWeek.DataSource = New Engagements()
    End Sub

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

End Class