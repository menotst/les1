using System.Windows;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainGrid.MouseUp += MainGrid_MouseUp;
        }

        //private void MainGrid_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("Координаты " + e.GetPosition(this).ToString());
        //}

    }
}
