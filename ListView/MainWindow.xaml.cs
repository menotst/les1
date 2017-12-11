using System.Collections.Generic;
using System.Windows;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }
        void FillList() {
            List<User> items = new List<User>();
            items.Add(new User() { Id = 1, Name = "Vasya", Age = 22, Salary = 3000 });
            items.Add(new User() { Id = 2, Name = "Petya", Age = 25, Salary = 6000 });
            items.Add(new User() { Id = 3, Name = "Kolya", Age = 23, Salary = 8000 });
            lvEmployee.ItemsSource = items;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Age}\t{Salary}";
        }
    }
}
