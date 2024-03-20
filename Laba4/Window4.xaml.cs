using System;
using System.Collections.Generic;
using System.Data;
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
using Laba4.DogPriutDSTableAdapters;

namespace Laba4
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        AdoptersTableAdapter adopters = new AdoptersTableAdapter();
        DogsTableAdapter dogs = new DogsTableAdapter();
        public Window4()
        {
            InitializeComponent();
            Grid4.ItemsSource = adopters.GetData();
            DogCB.ItemsSource = dogs.GetData();
            DogCB.DisplayMemberPath = "NameDog";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid4.ItemsSource = adopters.SearchBySurname(SearchBox.Text);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Grid4.ItemsSource = adopters.GetData();
        }

        private void DogCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DogCB.SelectedItem != null)
            {
                var id = (int)(DogCB.SelectedItem as DataRowView).Row[0];
                Grid4.ItemsSource = adopters.FiltrById(id);
            }
        }
    }
}
