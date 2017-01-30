Namespace Helpers
    Public Class EncryptionHelper
        ''' <summary>
        ''' Performs a simple encryption on text
        ''' </summary>
        ''' <param name="text">The text to be encrypted/decrypted</param>
        ''' <returns>The text that was encrypted/decrypted</returns>
        Public Function SimpleCrypt(ByVal text As String) As String
            ' Encrypts/decrypts the passed string using 
            ' a simple ASCII value-swapping algorithm
            Dim strTempChar As String = ""
            Dim i As Integer
            For i = 1 To Len(text)
                If Asc(Mid$(text, i, 1)) < 128 Then
                    strTempChar = CType(Asc(Mid$(text, i, 1)) + 128, String)
                ElseIf Asc(Mid$(text, i, 1)) > 128 Then
                    strTempChar = CType(Asc(Mid$(text, i, 1)) - 128, String)
                End If
                Mid$(text, i, 1) = Chr(strTempChar)
            Next i
            Return text
        End Function
    End Class
End Namespace