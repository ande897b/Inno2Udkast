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

namespace Inno2Udkast
{
    /// <summary>
    /// Interaction logic for WindowForSettings.xaml
    /// </summary>
    public partial class WindowForSettings : Window
    {
        MainWindow main = new MainWindow();
        public WindowForSettings()
        {
            InitializeComponent();
            this.Title="Indstillinger";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            main.Show();
            this.Close();
            
        }

        private void check2_Checked(object sender, RoutedEventArgs e)
        {

            main.btn3.Content = main.btn6.Content;
            main.btn5.Content = "";
            main.btn4.Content = "";
            main.btn6.Content = "";
        }

        private void Check1_Checked(object sender, RoutedEventArgs e)
        {
            main.btn1.Content = main.btn2.Content;
            main.btn3.Content = "";
            main.btn4.Content = "";
            main.btn5.Content = "";
            main.btn6.Content = "";
            main.btn2.Content = "";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slider.Value == 30)
            {

                main.btn3.Content = main.btn6.Content;

                main.btn6.Content = "";
            }
        }
    }
}
