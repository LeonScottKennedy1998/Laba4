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
using Laba4.DogPriutDSTableAdapters;

namespace Laba4
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        DogsTableAdapter dogs = new DogsTableAdapter();
        public Window3()
        {
            InitializeComponent();
            Grid3.ItemsSource = dogs.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid3.ItemsSource = dogs.SearchByName(SearchBox.Text);

        }
    }
}
