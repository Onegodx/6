using System;
using System.Collections.Generic;
using System.Globalization;
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
//Миньков Владимир 22исп21 14 вариант 6 базовый уровень 
namespace WpfApp5
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbN.Text, out int n))
            {
                double[] arr = new double[n];

               
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.NextDouble();
                }

               
                Array.Sort(arr, (x, y) => y.CompareTo(x));

              
                dg.ItemsSource = arr.Select(x => new { Value = x }).ToList();
            }
            else
            {
                MessageBox.Show("Некорректное число");
            }
        }
    }
}
