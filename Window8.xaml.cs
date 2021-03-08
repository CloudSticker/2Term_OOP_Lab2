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
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            GameLogic game = new GameLogic();
            Window9 task1 = new Window9();
            game.kset(Convert.ToInt32(KTextBox.Text));
            game.aset(game.kget());
            game.nset(Convert.ToInt32(NTextBox.Text));
            game.firstTurnset(AITurn.IsPressed);
            task1.Show();
            this.Hide();
        }
    }
}
