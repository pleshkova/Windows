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

namespace многооконное_приложение
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnPress_Click(object sender, RoutedEventArgs e)
        {
            Press press = new Press();
            press.Show();
        }

        private void btnHeader_Click(object sender, RoutedEventArgs e)
        {
            Header header = new Header();
            header.Show();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            Buttons buttons = new Buttons();
            buttons.Show();
        }

        private void btnIcon_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }
    }
}
