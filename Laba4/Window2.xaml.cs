using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laba4
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private DogPriutEntities dogpriut = new DogPriutEntities();
        public Window2()
        {
            InitializeComponent();
            Grid2.ItemsSource = dogpriut.Adopters.ToList();
            DogCB.ItemsSource = dogpriut.Dogs.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid2.ItemsSource = dogpriut.Adopters.ToList().Where(item => item.SurnameAdopter.Contains(SearchBox.Text));

        }

        private void DogCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DogCB.SelectedItem != null)
            { 
                var selected = DogCB.SelectedItem as Dogs;
                Grid2.ItemsSource = dogpriut.Adopters.ToList().Where(item => item.Dogs == selected);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Grid2.ItemsSource = dogpriut.Adopters.ToList();
        }
    }
}
