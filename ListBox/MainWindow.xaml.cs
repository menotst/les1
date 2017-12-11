﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> items = new ObservableCollection<Employee>();
        public MainWindow()
        {
            InitializeComponent();
            FillList();
        }
        void FillList()
        {            
            items.Add(new Employee() { Id = 1, Name = "Vasya", Age = 22, Salary = 3000 });
            items.Add(new Employee() { Id = 2, Name = "Petya", Age = 25, Salary = 6000 });
            items.Add(new Employee() { Id = 3, Name = "Kolya", Age = 23, Salary = 8000 });
            lbEmployee.ItemsSource = items;

            lbEmployee.Items.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
        }

        private void lbEmployee_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(e.Source.ToString());
        }

        private void lbEmployee_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Employee() { Id = 1, Name = "Sergey", Age = 26, Salary = 7000 });            
        }
    }

    public class Employee
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
