Imports System.Xml
Imports timeEntryBot.Helpers

Namespace Models
    Public Class Engagements
        Public Property Engagements() As List(Of Engagement)

        Sub New()
            Dim xmlNodeList As IEnumerable = XmlHelper.ReadElementsFromFile(FrmMain.XmlFilePath, FrmMain.XmlFileName)
            For Each nNode As XmlNode In xmlNodeList
                Dim name = ""
                Dim clientCode = ""
                Dim assignmentCode = ""
                Dim hoursPerDay = ""
                Dim location = ""
                For Each nChildNode As XmlNode In nNode.ChildNodes
                    Select Case nChildNode.Name
                        Case "Name"
                            name = nChildNode.InnerText
                        Case "ClientCode"
                            clientCode = nChildNode.InnerText
                        Case "AssignmentCode"
                            assignmentCode = nChildNode.InnerText
                        Case "HoursPerDay"
                            hoursPerDay = nChildNode.InnerText
                        Case "Location"
                            location = nChildNode.InnerText
                    End Select
                Next
                Engagements.Add(New Engagement(name, clientCode, assignmentCode, hoursPerDay, location))
            Next
        End Sub
    End Class
End Namespace