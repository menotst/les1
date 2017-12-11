using System.Windows;
using System.Windows.Media;

namespace WindowRelation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow childWindow = new ChildWindow();
            //Теперь MainWindow главное окно для childWindow
            childWindow.Owner = this;

            childWindow.ViewModel = "ViewModel";
            childWindow.Show();
            childWindow.ShowViewModel();

            foreach (Window window in this.OwnedWindows)
            {
                window.Background = new SolidColorBrush(Colors.Aquamarine);

                if (window is ChildWindow)
                    window.Title = "Новый заголовок";
            }

            
        }
    }
}
