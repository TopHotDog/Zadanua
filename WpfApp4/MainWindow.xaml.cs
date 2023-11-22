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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double A = Convert.ToDouble(textBoxA.Text);

            Double A2 = A * A;

            Double A4 = A2 * A2;

            Double A8 = A4 * A4;

            TbAnswer.Text += A2;
            TbAnswer_Copy.Text += A4;
            TbAnswer_Copy1.Text += A8;
        }
    }
}
