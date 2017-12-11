using System.Windows;
using System.Windows.Media;

namespace WindowRelation
{
    /// <summary>
    /// Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        public ChildWindow()
        {
            InitializeComponent();            
        }
        public string ViewModel { get; set; }
        public void ShowViewModel()
        {
            this.Owner.Background = new SolidColorBrush(Colors.Crimson);
            textBlock.Text = ViewModel;
        }
    }
}
