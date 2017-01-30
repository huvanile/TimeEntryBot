Imports System.Xml
Imports timeEntryBot.Helpers

Namespace Models
    Public Class Engagements
        Public Property Engagements() As List(Of Engagement)

        Sub New()
            Dim xmlNodeList As IEnumerable = XmlHelper.ReadElementsFromFile(FrmMain.XmlFilePath, FrmMain.XmlFileName)
            For Each xmlNode As XmlNode In xmlNodeList
                Dim eng As Engagement = XmlHelper.GetEngagementFromXmlNode(xmlNode)
                Engagements.Add(eng)
            Next
        End Sub
    End Class
End Namespace