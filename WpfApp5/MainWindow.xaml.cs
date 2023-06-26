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
//Миньков Владимир 22исп21 14 вариант 7_2 базовый уровень 
namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            int dotsCount = 0;
            int commasCount = 0;

            CultureInfo culture = CultureInfo.CurrentCulture;

            foreach (char c in text)
            {
                if (c == '.')
                {
                    if (!char.IsDigit(text[text.IndexOf(c) - 1]) || !char.IsDigit(text[text.IndexOf(c) + 1]))
                    {
                        dotsCount++;
                    }
                }
                else if (c == ',')
                {
                    if (!char.IsDigit(text[text.IndexOf(c) - 1]) || !char.IsDigit(text[text.IndexOf(c) + 1]))
                    {
                        commasCount++;
                    }
                }
            }

            dotsCountText.Text = dotsCount.ToString(culture);
            commasCountText.Text = commasCount.ToString(culture);
        }
    }
}
