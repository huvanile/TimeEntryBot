Imports System.IO
Imports System.Xml
Imports timeEntryBot.Models

Namespace Helpers

    Public Class XmlHelper

        Public Shared Sub WriteXmlFile(ByVal filePath As String, ByVal fileName As String, ByRef engagement As Engagement)

            'Create path if doesn't exist
            If (Not IO.Directory.Exists(filePath)) Then
                IO.Directory.CreateDirectory(filePath)
            End If

            'Check if the file already exists
            If IO.File.Exists(filePath + fileName) Then
                'The file exists
                Dim doc As New XmlDocument()
                doc.Load(filePath + fileName)

                'Check if the value already exists, if so update
                Dim profile As XmlNode = doc.SelectSingleNode("Engagements/Engagement[@name='" + engagement.Name + "']")
                If (profile IsNot Nothing) Then
                    'Let's update the node while we are here

                    'Update the attribute so they stay in sync
                    profile.Attributes(0).InnerText = engagement.Name

                    For Each nChildNode As XmlNode In profile.ChildNodes

                        Select Case nChildNode.Name
                            Case "Name"
                                nChildNode.InnerText = engagement.Name
                            Case "ClientCode"
                                nChildNode.InnerText = engagement.ClientCode
                            Case "AssignmentCode"
                                nChildNode.InnerText = engagement.AssignmentCode
                            Case "HoursPerDay"
                                nChildNode.InnerText = engagement.HoursPerDay
                            Case "Location"
                                nChildNode.InnerText = engagement.Location
                        End Select

                    Next

                Else

                    'If not then add the new node to the file and close it

                    Dim root As XmlNode = doc.DocumentElement

                    'Create a new node
                    Dim newElem As XmlElement = doc.CreateElement("Engagement")
                    newElem.SetAttribute("name", engagement.Name)

                    Dim childElement1 As XmlElement = doc.CreateElement("Name")
                    childElement1.InnerText = engagement.Name
                    newElem.AppendChild(childElement1)

                    Dim childElement2 As XmlElement = doc.CreateElement("ClientCode")
                    childElement2.InnerText = engagement.ClientCode
                    newElem.AppendChild(childElement2)

                    Dim childElement3 As XmlElement = doc.CreateElement("AssignmentCode")
                    childElement3.InnerText = engagement.AssignmentCode
                    newElem.AppendChild(childElement3)

                    Dim childElement4 As XmlElement = doc.CreateElement("HoursPerDay")
                    childElement4.InnerText = engagement.HoursPerDay
                    newElem.AppendChild(childElement4)

                    Dim childElement5 As XmlElement = doc.CreateElement("Location")
                    childElement5.InnerText = engagement.Location
                    newElem.AppendChild(childElement5)

                    'Add the node to the top of the document
                    root.InsertBefore(newElem, root.FirstChild)


                End If

                'Save the xml file and get out
                doc.Save(filePath + fileName)

            Else
                'the file doesn't exist
                Dim writer As New XmlTextWriter(filePath + fileName, Text.Encoding.UTF8)
                writer.WriteStartDocument(True)
                writer.Formatting = Formatting.Indented
                writer.Indentation = 2
                CreateClientCodeNode(engagement, writer)
                writer.WriteEndDocument()
                writer.Close()
            End If


        End Sub

        Public Shared Sub CreateClientCodeNode(ByRef engagement As Engagement, writer As XmlTextWriter)

            writer.WriteStartElement("Engagements")

            writer.WriteStartElement("Engagement")
            writer.WriteAttributeString("name", engagement.Name)

            writer.WriteStartElement("Name")
            writer.WriteString(engagement.Name)
            writer.WriteEndElement()

            writer.WriteStartElement("ClientCode")
            writer.WriteString(engagement.ClientCode)
            writer.WriteEndElement()

            writer.WriteStartElement("AssignmentCode")
            writer.WriteString(engagement.AssignmentCode)
            writer.WriteEndElement()

            writer.WriteStartElement("HoursPerDay")
            writer.WriteString(engagement.HoursPerDay)
            writer.WriteEndElement()

            writer.WriteStartElement("Location")
            writer.WriteString(engagement.Location)
            writer.WriteEndElement()

            writer.WriteEndElement()

            writer.WriteEndElement()
        End Sub

        Public Shared Function ReadElementsFromFile(xmlFilePath As String, xmlFileName As String) As IEnumerable
            Dim doc As New XmlDocument()
            doc.Load(xmlFilePath + xmlFileName)
            Dim elemList As IEnumerable = doc.GetElementsByTagName("Engagement")
            Return elemList
        End Function

        Public Shared Sub CreateClientCodeNode(ByVal name As String, ByVal clientCode As String, ByVal assignmentCode As String, ByVal hoursPerDay As Integer, location As String, writer As XmlTextWriter)

            writer.WriteStartElement("Engagements")

            writer.WriteStartElement("Name")
            writer.WriteString(name)
            writer.WriteEndElement()

            writer.WriteStartElement("ClientCode")
            writer.WriteString(clientCode)
            writer.WriteEndElement()

            writer.WriteStartElement("AssignmentCode")
            writer.WriteString(assignmentCode)
            writer.WriteEndElement()

            writer.WriteStartElement("HoursPerDay")
            writer.WriteString(hoursPerDay)
            writer.WriteEndElement()

            writer.WriteStartElement("Location")
            writer.WriteString(location)
            writer.WriteEndElement()

            writer.WriteEndElement()
        End Sub

        Friend Shared Function FindEngagementNodeByName(xmlFilePath As String, xmlFileName As String, selectedName As String) As Engagement
            Dim name = ""
            Dim clientCode = ""
            Dim assignmentCode = ""
            Dim hoursPerDay = ""
            Dim location = ""

            Dim xmlNodeList As IEnumerable = ReadElementsFromFile(xmlFilePath, xmlFileName)

            For Each nNode As XmlNode In xmlNodeList
                If nNode.Attributes.Item(0).InnerText = selectedName Then
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
                End If
            Next

            Return New Engagement(name, clientCode, assignmentCode, hoursPerDay, location)

        End Function

        Public Shared Sub DeleteEngagementNodeByName(xmlFilePath As String, xmlFileName As String, selectedName As String)
            Dim doc As New XmlDocument()
            doc.Load(xmlFilePath + xmlFileName)

            Dim profile As XmlNode = doc.SelectSingleNode("Engagements/Engagement[@name='" + selectedName + "']")
            If (profile IsNot Nothing) Then
                profile.RemoveAll()
            End If


            'Save the xml file and get out
            doc.Save(xmlFilePath + xmlFileName)


            '''TODO: Make this not so hacky so it'll remove the entire element above and you won't need this post fix
            File.WriteAllText(xmlFilePath + xmlFileName, File.ReadAllText(xmlFilePath + xmlFileName).Replace("  <Engagement>" + Environment.NewLine + "  </Engagement>" + Environment.NewLine, ""))
        End Sub
    End Class
End Namespace