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
    class Graph
    {
        List<Line> lineList = new List<Line>();

        public List<Line> Grid(double CanvasHeigh, double CanvasWidth)
        {
            double CellSize = CanvasHeigh / 20;

            for (int i = 0; i <= CanvasHeigh; i += Convert.ToInt32(CellSize))
            {
                if (i != 250)
                {
                    lineList.Add(DrawLine(0, i, CanvasWidth, i, Brushes.Black, 0.1));
                }

            }

            for (int i = 0; i <= CanvasWidth; i += Convert.ToInt32(CellSize))
            {
                if (i != 250)
                {
                    lineList.Add(DrawLine(i, 0, i, CanvasHeigh, Brushes.Black, 0.1));
                }

            }
            return lineList;
        }

        public Line DrawLine(double X1, double Y1, double X2, double Y2, Brush color, double thikness)
        {
            Line line = new Line();
            line.X1 = X1;
            line.Y1 = Y1;
            line.X2 = X2;
            line.Y2 = Y2;
            line.StrokeThickness = thikness;
            line.Stroke = color;
            return line;
        }

        public Polyline DrawGraph(double a, double b)
        {
            Polyline myPolygon = new Polyline();
            myPolygon.Stroke = System.Windows.Media.Brushes.Blue;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;


            PointCollection points = new PointCollection();
            for (double x = -10; x < 10; x += 0.001)
            {
                if ((x > a) && (x < b))
                {
                    Point p = new Point(x * 25 + 250, -1 * x * Math.Sin(x) * 25 + 250);
                    points.Add(p);
                }

            }

            myPolygon.Points = points;

            return myPolygon;
        }

    }
}
