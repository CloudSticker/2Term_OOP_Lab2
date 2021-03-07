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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public int K = 15;
        public int N = 0;
        public Window9()
        {
            InitializeComponent();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            Window1 task1 = new Window1();
            task1.Show();
        }

        private void StartGameBtn_Click(object sender, RoutedEventArgs e)
        {
            Window8 task1 = new Window8();
            this.Hide();
            task1.Show();
        }

        private void TurnBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            BolderLbl.Content = N;
            ValueLbl.Content = K;
            GiveSlider.Maximum = K;
            
        }

        private void GiveSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //ValueLbl.Content = GiveSlider.Value;
            //GiveSlider.TickFrequency = K;
        }
    }
}
