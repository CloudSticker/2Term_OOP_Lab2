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
        GameLogic game = new GameLogic();
        EndGameMessage endgamemessage = new EndGameMessage();
        public Window9()
        {
            InitializeComponent();
            GiveSlider.Minimum = 1;
        }

        private void interfaceInit()
        {
            game.recount();
            BolderLbl.Content = game.nget();
            GiveSlider.Maximum = game.aget();
            ValueLbl.Content = GiveSlider.Value;
        }

        private void endgame(bool a)
        {
            if (a)
            {
                endgamemessage.resultCheck(a);
                this.Hide();
                endgamemessage.Show();//человек
            } else
            {
                endgamemessage.resultCheck(a);
                this.Hide();
                endgamemessage.Show();//ai
            }
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            Window1 task1 = new Window1();
            task1.Show();
        }
        


        private void TurnBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!game.playerTurn(Convert.ToInt32(GiveSlider.Value)))
                endgame(true);
            if (!game.aiTurn())
                endgame(false);
            interfaceInit();
        }


        
        private void GiveSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            interfaceInit();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            interfaceInit();

        }

        
    }
}
