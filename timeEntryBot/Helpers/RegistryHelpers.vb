Imports timeEntryBot.Globals

Public Class RegistryHelpers

    ''' <summary>
    ''' This pre-populates registry values with defaults
    ''' this is the only place defaults should ever be defined
    ''' </summary>
    Public Shared Sub AddressNulls()
        Try

            'numbers
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "Hours", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "Hours", Nothing) = 0 Then _
                My.Computer.Registry.SetValue(REGISTRYFOLDER, "Hours", 8)

            'strings
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "ClientCode", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "ClientCode", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "ClientCode", "9996610") 'gt firm admnistration
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "AssgnCode", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "AssgnCode", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "AssgnCode", "26010") 'firm administration DAL
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "AliasName", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "AliasName", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "AliasName", "Admin DAL")
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "LocationCode", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "LocationCode", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "LocationCode", "260") 'dallas
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "SiteURL", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "SiteURL", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "SiteURL", "https://cms.gt.com")
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "UserN", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "UserN", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "UserN", "USXXXXX") 'should this be this way? //TODO: Test
            If My.Computer.Registry.GetValue(REGISTRYFOLDER, "Password", Nothing) Is Nothing _
                Or My.Computer.Registry.GetValue(REGISTRYFOLDER, "Password", Nothing) = "" _
                Then My.Computer.Registry.SetValue(REGISTRYFOLDER, "Password", "Password")

        Catch exAll As Exception
            Debug.Print("CAUGHT ERROR IN aDDRESSnULLS:  " & exAll.Message)
            MsgBox("An error has occurred with the bot's preferences.  Please close and reopen this bot and try again.", vbCritical, TITLE & " v" & VERSION)
        End Try
    End Sub

    ''' <summary>
    ''' This populates the global variables with their values that were stored in the registry
    ''' </summary>
    Public Shared Sub GetPrefs()
        Try
            ClientCode = My.Computer.Registry.GetValue(REGISTRYFOLDER, "ClientCode", Nothing)
            AssgnCode = My.Computer.Registry.GetValue(REGISTRYFOLDER, "AssgnCode", Nothing)
            LocationCode = My.Computer.Registry.GetValue(REGISTRYFOLDER, "LocationCode", Nothing)
            Hours = My.Computer.Registry.GetValue(REGISTRYFOLDER, "Hours", Nothing)
            SiteURL = My.Computer.Registry.GetValue(REGISTRYFOLDER, "SiteURL", Nothing)
            UserN = My.Computer.Registry.GetValue(REGISTRYFOLDER, "UserN", Nothing)
            Password = My.Computer.Registry.GetValue(REGISTRYFOLDER, "Password", Nothing)
            AliasName = My.Computer.Registry.GetValue(REGISTRYFOLDER, "AliasName", Nothing)
        Catch exAll As Exception
            Debug.Print("CAUGHT ERROR IN getPrefs: " & exAll.Message)
            MsgBox("An error has occurred when getting the bot's preferences.  Please close and reopen this bot and try again.", vbCritical, TITLE & " v" & VERSION)
        End Try
    End Sub

End Class
