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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            private void Button_Click(object sender, RoutedEventArgs e)
            { 
            double a = Convert.ToDouble(textBoxA.Text);
                double x = a / 12;
            double b = Math.Exp(-a * x);
            double y = 1 - Math.Exp(-a * x) * Math.Sin(a * x + b);
            TbAnswert.Text += y;
        }
    }
}
