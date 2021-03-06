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
using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Graph graph = new Graph();
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 task1 = new Window4();
            this.Hide();
            task1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window6 task1 = new Window6();
            this.Hide();
            graph.check = 2;
            task1.Show();
        }

        private void task3button_Click(object sender, RoutedEventArgs e)
        {
            Window9 task1 = new Window9();
            this.Hide();
            task1.Show();
        }

        private void DKAWindow_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            MainWindow task1 = new MainWindow();
            task1.Show();
        }
    }
}



