Imports System.IO
Imports System.Text
Imports System.Xml
Imports timeEntryBot.Models

Namespace Helpers

    Public Class XmlHelper

        Public Shared Sub WriteXmlFile(ByVal filePath As String, ByVal fileName As String, ByRef engagement As Engagement)
            Dim xmlFullFileName As String = filePath + fileName
            'Create folder path if doesn't exist
            If (Not Directory.Exists(filePath)) Then
                Directory.CreateDirectory(filePath)
            End If

            'Check if the file already exists
            If File.Exists(xmlFullFileName) Then
                'The file exists
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(xmlFullFileName)

                'Now let's add the new node to the file or replace it if it exists
                AddEngagementXmlNodeToDocument(engagement, xmlDoc)

                'Save the xml file and get out
                xmlDoc.Save(xmlFullFileName)

            Else
                'the file doesn't exist so create the file
                Dim writer As New XmlTextWriter(xmlFullFileName, Encoding.UTF8)
                writer.WriteStartDocument(True)
                writer.Formatting = Formatting.Indented
                writer.Indentation = 2
                writer.WriteStartElement("Engagements")
                writer.WriteEndElement()
                writer.WriteEndDocument()
                writer.Close()

                'Now that the file is created add the engagement element
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(xmlFullFileName)
                AddEngagementXmlNodeToDocument(engagement, xmlDoc)
                xmlDoc.Save(xmlFullFileName)
            End If


        End Sub

        Private Shared Sub AddEngagementXmlNodeToDocument(engagement As Engagement, xmlDoc As XmlDocument)

            Dim root As XmlNode = xmlDoc.DocumentElement
            Dim newElem As XmlElement = CreateEngagementXmlNode(engagement, xmlDoc)

            Dim oldElem As XmlNode = xmlDoc.SelectSingleNode("Engagements/Engagement[@name='" + engagement.Name + "']")
            If (oldElem IsNot Nothing) Then
                'Replace the old element with the new one so you stay updated
                root.ReplaceChild(newElem, oldElem)
            Else
                'There was no old element so just add the new element to the top of the document
                root.InsertBefore(newElem, root.FirstChild)
            End If

        End Sub

        Private Shared Function CreateEngagementXmlNode(engagement As Engagement, xmlDoc As XmlDocument) As XmlElement

            'Create a new node
            Dim newElem As XmlElement = xmlDoc.CreateElement("Engagement")
            newElem.SetAttribute("name", engagement.Name)

            Dim childElement1 As XmlElement = xmlDoc.CreateElement("Name")
            childElement1.InnerText = engagement.Name
            newElem.AppendChild(childElement1)

            Dim childElement2 As XmlElement = xmlDoc.CreateElement("ClientCode")
            childElement2.InnerText = engagement.ClientCode
            newElem.AppendChild(childElement2)

            Dim childElement3 As XmlElement = xmlDoc.CreateElement("AssignmentCode")
            childElement3.InnerText = engagement.AssignmentCode
            newElem.AppendChild(childElement3)

            Dim childElement4 As XmlElement = xmlDoc.CreateElement("HoursPerDay")
            childElement4.InnerText = engagement.HoursPerDay
            newElem.AppendChild(childElement4)

            Dim childElement5 As XmlElement = xmlDoc.CreateElement("Location")
            childElement5.InnerText = engagement.Location
            newElem.AppendChild(childElement5)

            Return newElem
        End Function

        Public Shared Function ReadElementsFromFile(xmlFilePath As String, xmlFileName As String) As IEnumerable
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(xmlFilePath + xmlFileName)
            Dim elemList As IEnumerable = xmlDoc.GetElementsByTagName("Engagement")
            Return elemList
        End Function

        Friend Shared Function FindEngagementNodeByName(xmlFilePath As String, xmlFileName As String, selectedName As String) As Engagement

            Dim xmlNodeList As IEnumerable = ReadElementsFromFile(xmlFilePath, xmlFileName)

            For Each xmlNode As XmlNode In xmlNodeList
                If xmlNode.Attributes.Item(0).InnerText = selectedName Then
                    Return GetEngagementFromXmlNode(xmlNode)
                End If
            Next
            Throw New ArgumentOutOfRangeException(selectedName, "TimeEntryBot did not find a matching XML Node")
        End Function

        Public Shared Function GetEngagementFromXmlNode(xmlNode As XmlNode) As Engagement
            Dim name = ""
            Dim clientCode = ""
            Dim assignmentCode = ""
            Dim hoursPerDay = ""
            Dim location = ""

            For Each nChildNode As XmlNode In xmlNode.ChildNodes

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
            Return New Engagement(name, clientCode, assignmentCode, hoursPerDay, location)
        End Function

        Public Shared Sub DeleteEngagementNodeByName(xmlFilePath As String, xmlFileName As String, selectedName As String)
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(xmlFilePath + xmlFileName)

            Dim profile As XmlNode = xmlDoc.SelectSingleNode("Engagements/Engagement[@name='" + selectedName + "']")
            If (profile IsNot Nothing) Then
                profile.RemoveAll()
            End If

            'Save the xml file and get out
            xmlDoc.Save(xmlFilePath + xmlFileName)


            '''TODO: Make this not so hacky so it'll remove the entire element above and you won't need this post fix
            File.WriteAllText(xmlFilePath + xmlFileName, File.ReadAllText(xmlFilePath + xmlFileName).Replace("  <Engagement>" + Environment.NewLine + "  </Engagement>" + Environment.NewLine, ""))
        End Sub
    End Class
End Namespace