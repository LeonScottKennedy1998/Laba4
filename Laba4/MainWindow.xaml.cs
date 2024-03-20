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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DogPriutEntities dogpriut = new DogPriutEntities();
        public MainWindow()
        {
            InitializeComponent();
            Grid1.ItemsSource = dogpriut.Dogs.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = dogpriut.Dogs.ToList().Where(item => item.NameDog.Contains(SearchBox.Text));

        }
    }
}
