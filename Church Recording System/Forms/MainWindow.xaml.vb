
Imports System.Data.OleDb

Class MainWindow

    Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded

        'hide buttons
        With Me
            .cmdBaptismal.Visibility = Windows.Visibility.Hidden
            .cmdConfirmation.Visibility = Windows.Visibility.Hidden
        End With
        Dim newwindow As New Login

        With newwindow
            .ShowDialog()
        End With
    End Sub
End Class
