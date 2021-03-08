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
using WpfAnimatedGif;
using System.Media;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        Random rnd = new Random();
        Graph graph = new Graph();
        List<Line> lineList = new List<Line>();
        int[,] arr = new int[10, 10];
        int[,] mass = new int[10, 10];
        int[,] save = new int[10, 10];
        int DeathCount = 0, GenCount = 0, AliveCount;
        SoundPlayer spf = new SoundPlayer(WpfApp1.Properties.Resources.furas);
        public Window7()
        {
            InitializeComponent();
            spf.Load();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                }

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    AddNum(i * 50 + 5, j * 50 + 15, Convert.ToString(arr[i, j]));

        }


        void ClearCanvas()
        {
            Canvas1.Children.Clear();
            lineList = graph.Grid(Canvas1.Height, Canvas1.Width, 10);
            for (int i = 0; i < lineList.Count; i++)
                Canvas1.Children.Add(lineList[i]);
        }

        void Restart()
        {

            DeathNumLbl.Content = $"Количество смертей: 0";
            GenNumLbl.Content = $"Количество генераций: 0";
            TurnBtn.IsEnabled = true;
            DeathCount = 0;
            GenCount = 0; 
            AliveCount = 0;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                }
            ClearCanvas();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    AddNum(i * 50 + 5, j * 50 + 15, Convert.ToString(arr[i, j]));
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (arr[i, j] == 1)
                        AliveCount++;
                }
            AliveNumLbl.Content = $"Количество выживших: {AliveCount}";
            AliveCount = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool areArrEqual = true;

            ClearCanvas();

            

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (arr[i, j] == 1)
                        AliveCount++;
                }

            AliveNumLbl.Content = $"Количество выживших: {AliveCount}";
            AliveCount = 0;

            Generation();


            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (arr[i, j] != mass[i, j])
                        areArrEqual = false;

            

            if (!areArrEqual)
            {
                GenNumLbl.Content = $"Количество генераций: {++GenCount}";
            }
               
            else
            {
                GenNumLbl.Content = $"Окончательное количество генераций: {GenCount}";
                TurnBtn.IsEnabled = false;
            }


            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {

                    if (mass[i, j] == 1)
                        DeathCount++;
                    arr[i, j] = mass[i, j];
                }

            DeathNumLbl.Content = $"Количество смертей: {DeathCount}";






            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    AddNum(i * 50 + 5, j * 50 + 15, Convert.ToString(arr[i, j]));

        }

        void Generation()
        {

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    int k = neighbors(i, j);
                    if ((k < 2)||(k > 3))
                    {
                       
                        mass[i, j] = 0;
                    }else if (k == 3)
                    {
                        mass[i, j] = 1;
                    }
                    else
                    {
                        mass[i, j] = arr[i, j];
                    }
                }
         
        }

        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        {
            Restart();
            var controller = ImageBehavior.GetAnimationController(Fura);
            controller.Play();
            spf.Play();
        }



        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window2 task1 = new Window2();
            this.Hide();
            task1.Show();
        }

        private void Fura_AnimationCompleted(object sender, RoutedEventArgs e)
        {
            var controller = ImageBehavior.GetAnimationController(Fura);
            controller.GotoFrame(0);
            controller.Pause();
        }

        public int neighbors(int i1, int j1)
        {
            int k = 0;
            for (int i = (i1 - 1); i <= (i1 + 1); i++)
                for (int j = (j1 - 1); j <= (j1 + 1); j++)
                {
                    if (((i != -1)&&( j != -1)) && ((i != i1) || (j != j1)))
                    {
                        if (((j >= 0) && (j <= 9)) && ((i >= 0) && (i <= 9)))
                            if (arr[i, j] == 1)
                                k++;
                    }
                }
            return k;
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
