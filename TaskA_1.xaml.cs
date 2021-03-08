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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public string ast;
        public string bst;
        public Window4()
        {
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ast = ain.Text;
        }

        private void bin_TextChanged(object sender, TextChangedEventArgs e)
        {
            bst = bin.Text; 
        }

        private void count_button_Click(object sender, RoutedEventArgs e)
        {
            int c = int.Parse(ast) + int.Parse(bst);
            cout.Text = c.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Window1 task1 = new Window1();
            task1.Show();
        }
    }
}
