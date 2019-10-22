using System.Windows;

namespace CreatePdfViewerControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pdfViewerControl.Load(@"../../Data/Barcode.pdf");
        }
    }
}
