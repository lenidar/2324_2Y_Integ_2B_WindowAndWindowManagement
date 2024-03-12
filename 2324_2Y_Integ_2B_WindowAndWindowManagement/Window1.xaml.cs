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

namespace _2324_2Y_Integ_2B_WindowAndWindowManagement
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public Window1(string message)
        {
            InitializeComponent();
            this.Title = message;
        }
        public Window1(int size)
        {
            InitializeComponent();
            this.Width = size;
            this.Height = size;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WIndowManager.wWindow = false;
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Boooo");
            this.Title = WIndowManager.message;
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            this.Title = WIndowManager.message;
        }
    }
}
