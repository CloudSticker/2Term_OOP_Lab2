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
using System.Media;
using WpfAnimatedGif;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        SoundPlayer sp = new SoundPlayer(Properties.Resources.Tardis_Landing_01);
        public Window3()
        {
            InitializeComponent();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            sp.Load();
            sp.Play();
        }

        private void TARDIS_AnimationCompleted(object sender, RoutedEventArgs e)
        {
            MainWindow task1 = new MainWindow();
            this.Hide();
            task1.Show();
        }
    }
}
