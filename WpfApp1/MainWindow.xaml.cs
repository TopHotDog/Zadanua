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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(textBoxA.Text);
            Double b = Convert.ToDouble(textBoxB.Text);

            Double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Double p = a + b + c;

            TbAnswer.Text += c;
            TbAnswer_Copy.Text += p;
        }
    }
}