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


namespace WpfApp_one
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Car car;

            //car = new Car("Red");
            //car = new Car("Green");
        }

                       

        private void butt_clickMe_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Button clickMe;
            SillyMessages SM = new SillyMessages();
            
            clickMe = (Button) sender;
            clickMe.Content = String.Concat("RIGHT BUTTON ", SM.Mumble(1));
        }

        private void butt_clickMe_Click(object sender, RoutedEventArgs e)
        {
            Button clickMe;
            SillyMessages SM = new SillyMessages();
            
            clickMe = (Button)sender;
            clickMe.Content = String.Concat("LEFT BUTTON ",SM.Mumble(2));
        }
    }
}
