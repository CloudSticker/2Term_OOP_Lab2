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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 task1 = new Window5();
            this.Hide();
            task1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window6 task1 = new Window6();
            this.Hide();
            task1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window7 task1 = new Window7();
            this.Hide();
            task1.Show();
        }
    }
}
