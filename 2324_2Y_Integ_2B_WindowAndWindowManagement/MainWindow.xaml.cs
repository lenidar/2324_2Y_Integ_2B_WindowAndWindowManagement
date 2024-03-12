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

namespace _2324_2Y_Integ_2B_WindowAndWindowManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if(!WIndowManager.mWindow)
            {
                WIndowManager.mw = this;
                WIndowManager.mWindow = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Window1 w1 = new Window1();
            //MessageBox.Show("CLICK!");

            if (!WIndowManager.wWindow)
            {
                WIndowManager.w1 = new Window1();
                WIndowManager.wWindow = true;
                WIndowManager.w1.Show();
            }
            else
            {
                WIndowManager.w1.Focus();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WIndowManager.mWindow = false;
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(":(");
            WIndowManager.message = uInput.Text;
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            WIndowManager.message = uInput.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            w1.Hide();
        }
    }
}
