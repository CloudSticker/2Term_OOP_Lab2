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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        Graph graph = new Graph();
        List<Line> lineList = new List<Line>();
        public int check;
        public Window6()
        {
            InitializeComponent();
            TextBoxB.Text = "10";
            TextBoxA.Text = "-10";
            lineList = graph.Grid(Canvas1.Height, Canvas1.Width);
            ClearCanvas();

        }

        public void Paint_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            double a = Convert.ToDouble(TextBoxA.Text);
            double b = Convert.ToDouble(TextBoxB.Text);
            Canvas1.Children.Add(graph.DrawGraph(a, b, check));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
        }

        void ClearCanvas()
        {
            Canvas1.Children.Clear();
            for (int i = 0; i < lineList.Count; i++)
                Canvas1.Children.Add(lineList[i]);
            Canvas1.Children.Add(graph.DrawLine(250, 0, 250, 500, Brushes.Red, 1));
            Canvas1.Children.Add(graph.DrawLine(0, 250, 500, 250, Brushes.Red, 1));
        }

       

        void IsTextBoxNum()
        {
            bool IsItNum1 = true, IsItNum2 = true;
            double a = 0;

            

            IsItNum1 = Double.TryParse(TextBoxA.Text, out a);
            IsItNum2 = Double.TryParse(TextBoxB.Text, out a);

            if ((!IsItNum1) || (!IsItNum2))
            {
                TextBoxB.Text = "10";
                TextBoxA.Text = "-10";
            }
        }

        private void TextBoxA_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsTextBoxNum();
        }

        private void TextBoxB_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsTextBoxNum();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            Window1 task1 = new Window1();
            task1.Show();
        }
    }

}
            