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
using System.Diagnostics;
using System.Media;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer sp = new SoundPlayer(Properties.Resources.open);
        SoundPlayer sp2 = new SoundPlayer(Properties.Resources.bell);
        public MainWindow()
        {
            InitializeComponent();
            sp.Load();
            sp2.Load();
        }




        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void DKDBtn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 DKA = new Window1();
            sp.PlaySync();
            this.Hide();
            DKA.Show();

        }

        private void DKABtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Window2 DKD = new Window2();
            sp.PlaySync();
            this.Hide();
            DKD.Show();
        }

        private void DKDBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            Door2.Visibility = Visibility.Visible;
        }

        private void DKABtn_MouseEnter(object sender, MouseEventArgs e)
        {
            Door1.Visibility = Visibility.Visible;
        }

        private void DKDBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            Door2.Visibility = Visibility.Hidden;
        }

        private void DKABtn_MouseLeave(object sender, MouseEventArgs e)
        {
            Door1.Visibility = Visibility.Hidden;
        }

        private void exitbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sp2.PlaySync();
            Application.Current.Shutdown();
        }

        private void exitbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush myBrush = new SolidColorBrush(Color.FromArgb(50, 255, 40, 0));
            exitbtn.Background = myBrush;
        }

        private void exitbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush myBrush = new SolidColorBrush(Color.FromArgb(0, 10, 10, 10));
            exitbtn.Background = myBrush;
        }
    }
}
