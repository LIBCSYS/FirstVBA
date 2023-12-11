Imports System.Windows

Class MainWindow
    Public Sub New()
        InitializeComponent()
        DisplayHelloWorld()
    End Sub

    Private Sub DisplayHelloWorld()
        Dim helloLabel As New Label()
        helloLabel.Content = "Welcome to LIBC Development Lab.  libcxyz@gmail.com"
        Content = helloLabel
    End Sub
End Class