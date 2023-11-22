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

namespace WpfApp2
{
    
    public partial class MainWindow : Window
    {
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Double x = Convert.ToDouble(textBoxY.Text);



            Double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7; 

            TbAnswer.Text += x;

        }
    }

}