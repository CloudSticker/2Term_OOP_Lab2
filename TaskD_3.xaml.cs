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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        Graph graph = new Graph();
        List<Line> lineList = new List<Line>();

        public Window7()
        {
            InitializeComponent();
        }


        void ClearCanvas()
        {
            Canvas1.Children.Clear();
            lineList = graph.Grid(Canvas1.Height, Canvas1.Width, 10);
            for (int i = 0; i < lineList.Count; i++)
                Canvas1.Children.Add(lineList[i]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            ClearCanvas();
            for(int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    AddNum(j * 50 + 5, i * 50 + 15, Convert.ToString(rnd.Next(0, 9)));  
                }
                   

        }

        void AddNum(int X, int Y, string num)
        {
            TextBlock txt = new TextBlock();
            txt.FontSize = 30;
            txt.Text = num;
            Canvas.SetTop(txt, X);
            Canvas.SetLeft(txt, Y);
            Canvas1.Children.Add(txt);
        }
    }
}
