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
using System.Diagnostics;


namespace Inno2Udkast
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            WindowForSettings win4 = new WindowForSettings();
            win4.Show();
            this.Close();
        }

      
        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            var win2 = new Window2();            
            win2.Show();
            win2.webBrowser.Navigate("https://www.valdemarsro.dk/chili-con-carne/");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            var win3 = new Window3();
            win3.Show();
            win3.webBrowser.Navigate("https://bit.ly/2xmbc0z");
        }
       
    }
}
