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
            
            Title = "Smart Køleskab";
          
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

        private void importButton_Click(object sender, RoutedEventArgs e)
        {
      
            MessageBoxResult result = MessageBox.Show("Importér sidste kvitering?", "Importér sidste kvitering?", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Txt6.Text = "Kartofler    Udløber om 14 dage";
                    Txt5.Text = "Ost             Udløber om 9 dage";
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Inventar blev IKKE importeret", "");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Mission Aborted", "My App");
                    break;
            }
            
        
        }
        
    }
}
