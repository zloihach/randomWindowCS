using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //8.	Окно случайного размера
    //и случайного цвета, получаемый путём закрашивания пикселей
    //случайной области экрана перемещается
    //по экрану с периодичность раз в 3 секунды.
    //При нажатии на окно оно должен остановиться.
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                this.Show();
                int r = rnd.Next(0, 255);
                int g = rnd.Next(0, 255);
                int b = rnd.Next(0, 255);
                this.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
                this.Width = rnd.Next(100, 500);
                this.Height = rnd.Next(100, 500);
                this.Title = "Random window";
                this.Left = rnd.Next(0, 500);
                this.Top = rnd.Next(0, 500);
                Thread.Sleep(3000);
            }
        }
        
    }

}