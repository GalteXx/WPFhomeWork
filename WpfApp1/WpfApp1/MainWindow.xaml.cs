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
//using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        bool a = false;
        SolidColorBrush red1 = new SolidColorBrush();
        SolidColorBrush gren = new SolidColorBrush();
        SolidColorBrush yell = new SolidColorBrush();
        SolidColorBrush net = new SolidColorBrush();
        DispatcherTimer timer = new DispatcherTimer();
         
        void colChange(ref bool a)
        {
            text.Content = Convert.ToString(a);
            if (red.Fill == red1 || (red.Fill == net && yel.Fill == net && gr.Fill == net))
            {
                gr.Fill = gren;
                yel.Fill = net;
                red.Fill = net;
                a = true;
            }
            else if(gr.Fill == gren && a == true)
            {
                for(int i = 0; i <= 3; i++)
                {
                    if (i % 2 == 0) { gr.Fill = net; }
                    else { gr.Fill = gren; }
                }
                a = false;
            }
            //else if()
        }
        */
        public MainWindow()
        {
            InitializeComponent();
            red.Fill = Brushes.Gray;
            yel.Fill = Brushes.Gray;
            gr.Fill = Brushes.Gray;
            /*наверное можно было это короче сделать
            red1.Color = Color.FromArgb(255, 255, 0, 0);
            gren.Color = Color.FromArgb(255, 0, 255, 0);
            yell.Color = Color.FromArgb(255, 255, 255, 0);
            net.Color = Color.FromArgb(255, 255, 255, 255);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 5);
            gr.Fill = net;
            yel.Fill = net;
            red.Fill = net;
            */
            
        }
        /*
        private void timer_Tick(object sender, EventArgs e)
        {
            colChange(ref a);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();  
        }
        */
        //да ну бред зачем я столько всего сделал...
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "Why? :(";
            btn1.IsEnabled = false;
            bool a = false;
            while (true)
            {

                if (red.Fill == Brushes.Red || (red.Fill == Brushes.Gray && yel.Fill == Brushes.Gray && gr.Fill == Brushes.Gray))
                {
                    text.Content = "10";
                    gr.Fill = Brushes.Green;
                    yel.Fill = Brushes.Gray;
                    red.Fill = Brushes.Gray; a = true;
                    //КОСТЫЛИ
                    for(int i = 9; i >= 6; i--)
                    {
                        await Task.Delay(1000);
                        text.Content = Convert.ToString(i);
                    }
                    
                }
                else if(gr.Fill == Brushes.Green && a)
                {
                    
                    for(int i = 5; i >= 0; i--)
                    {
                        if (i % 2 == 1) { gr.Fill = Brushes.Gray; }
                        else { gr.Fill = Brushes.Green; }
                        await Task.Delay(1000);
                        text.Content = Convert.ToString(i);
                    }

                    await Task.Delay(1000);
                    a = false;
                }
                else if(gr.Fill == Brushes.Green && !a)
                {
                    text.Content = "It's not red";
                    yel.Fill = Brushes.Yellow;
                    gr.Fill = Brushes.Gray;
                    await Task.Delay(2000);
                }
                else if(yel.Fill == Brushes.Yellow)
                {
                    yel.Fill = Brushes.Gray;
                    red.Fill = Brushes.Red;
                    await Task.Delay(10000);
                }
            }
        }
    }
}
