Imports System.Speech

Class Application

    Public username(255) As String
    Public emailaddress(100) As String
    Public schoolname(200) As String
    Public age(2) As Integer
    Public rollno(4) As Integer
    Public moduleboard As Board

    Public Enum Board
        NCERT
        CBSE
        ICSE
        ISC
    End Enum

    Private Sub Application_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
    End Sub
End Class

