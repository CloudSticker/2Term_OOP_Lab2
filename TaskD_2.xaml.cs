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
        public Window6()
        {
            InitializeComponent();
            for (int i = 0; i <= Canvas1.Height; i +=  Convert.ToInt32(Canvas1.Height / 20))
            {
                if (i != 200)
                {
                    DrawLine(0, i, Canvas1.Width, i);
                }
               
            }

            for (int i = 0; i <= Canvas1.Width; i += Convert.ToInt32(Canvas1.Width / 20))
            {
                if (i != 250)
                {
                    DrawLine(i, 0, i, Canvas1.Height);
                }

            }

            void DrawLine(double X1, double Y1, double X2, double Y2)
            {
                Line line = new Line();
                line.X1 = X1;
                line.Y1 = Y1;
                line.X2 = X2;
                line.Y2 = Y2;
                line.StrokeThickness = 0.1;
                line.Stroke = Brushes.Black;
                Canvas1.Children.Add(line);
            }
        }
    }

}
