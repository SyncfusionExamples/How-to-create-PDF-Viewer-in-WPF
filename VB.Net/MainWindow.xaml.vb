Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        PdfViewerControl.Load("../../Data/Barcode.pdf")
    End Sub
End Class
