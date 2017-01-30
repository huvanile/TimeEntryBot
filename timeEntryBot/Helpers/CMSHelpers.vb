Imports timeEntryBot.Globals

Namespace Helpers

    Public Class CMSHelpers
        ''' <summary>
        ''' determines if the assgn and client code the user specified is already present in the site
        ''' </summary>
        ''' <returns>boolean</returns>
        Public Shared Function IsCodeVisible(_html As String) As Boolean
            If _html Like "*" & ClientCode & "." & AssgnCode & "*" Then Return True Else Return False
        End Function

        Public Shared Function getTimeKeeperUno(_html As String) As String
            If _html Like "*id=EmployeeUno*" Then
                Dim splitholder
                splitholder = Split(_html, "id=EmployeeUno onkeydown=""EditControl_OnKeyDown('TkprLookupLink')"" style=""WIDTH: 8px; VISIBILITY: hidden"" value=")
                splitholder = Split(splitholder(1), " name=EmployeeUno")
                Return Trim(splitholder(0))
            Else
                Throw New Exception
            End If
        End Function

        ''' <summary>
        ''' start of Week for CMS to display in the time entry page  
        ''' ALWAYS SUN
        ''' </summary>
        ''' <returns>start of of week for time entry</returns>
        Public Shared Function getPeriodStart() As String
            Dim dow As Short = Weekday(Now(), vbSunday) 'number of today's dow (Day Of Week) (1 = sun, 2= monday, etc.)
            If dow = 1 Then
                Return Format(Date.Now().AddDays(-7), "yyyy-MM-dd")
            Else
                Return Format(Date.Now().AddDays((dow - 1) * -1), "yyyy-MM-dd")
            End If
        End Function

        ''' <summary>
        ''' start of Week for CMS to display in the time entry page  
        ''' ALWAYS SAT
        ''' </summary>
        ''' <returns>end of of week for time entry</returns>
        Public Shared Function getPeriodEnd() As String
            Dim dow As Short = Weekday(Now(), vbSunday) 'number of today's dow (Day Of Week) (1 = sun, 2= monday, etc.)
            Select Case dow
                Case 1 'sun
                    Return Format(Date.Now().AddDays(-1), "yyyy-MM-dd")
                Case 2 'mon
                    Return Format(Date.Now().AddDays(+5), "yyyy-MM-dd")
                Case 3
                    Return Format(Date.Now().AddDays(+4), "yyyy-MM-dd")
                Case 4
                    Return Format(Date.Now().AddDays(+3), "yyyy-MM-dd")
                Case 5
                    Return Format(Date.Now().AddDays(+2), "yyyy-MM-dd")
                Case 6
                    Return Format(Date.Now().AddDays(+1), "yyyy-MM-dd")
                Case 7
                    Return Format(Date.Now(), "yyyy-MM-dd")
            End Select
        End Function

    End Class
End Namespace