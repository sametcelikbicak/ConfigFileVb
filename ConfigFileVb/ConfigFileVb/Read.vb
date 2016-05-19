Imports System.Configuration

Public NotInheritable Class Read

    Public Shared Function FromConfig(ByVal key As String) As String
        Return ConfigurationManager.AppSettings.Get(key)
    End Function

End Class
