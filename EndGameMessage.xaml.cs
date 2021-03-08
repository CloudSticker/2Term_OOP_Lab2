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
    /// Логика взаимодействия для EndGameMessage.xaml
    /// </summary>
    public partial class EndGameMessage : Window
    {
        public EndGameMessage()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
        internal void resultCheck(bool a)
        {
            if (a)
            {
                PlayerOutLbl.Content = "Поздравляю, ты победил!";
                AiOutLbl.Content = "ИИ проиграл =(";
            } else
            {
                PlayerOutLbl.Content = "К сожалению, ты проиграл...";
                AiOutLbl.Content = "ИИ выйграл =)";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Window8 task1 = new Window8();
            this.Hide();
            task1.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 task1 = new Window1();
            this.Hide();
            task1.Show();
        }
    }
}
