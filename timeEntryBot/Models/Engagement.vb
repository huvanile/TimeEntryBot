Namespace Models
    Public Class Engagement
        Public Property Name As String

        Public Property ClientCode As String

        Public Property AssignmentCode As String

        Public Property HoursPerDay As String

        Public Property Location() As String


        Sub New(ByVal name As String, ByVal clientCode As String, ByVal assignmentCode As String, ByVal hoursPerDay As Integer, location As String)
            Me.Name = name
            Me.ClientCode = clientCode
            Me.AssignmentCode = assignmentCode
            Me.HoursPerDay = hoursPerDay
            Me.Location = location
        End Sub
    End Class
End Namespace