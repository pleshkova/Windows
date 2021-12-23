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
    /// Логика взаимодействия для Icon.xaml
    /// </summary>
    public partial class Buttons : Window
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void btnYas_Click(object sender, RoutedEventArgs e)
        {
            Press press = new Press();
            press.Show();
            press.lblHello.Content = "Hello to you too!";
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            Press press = new Press();
            press.Show();
            press.lblHello.Content = "Oh well, to bad!";
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            Press press = new Press();
            press.Show();
            press.lblHello.Content = "Never mind then...";
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
