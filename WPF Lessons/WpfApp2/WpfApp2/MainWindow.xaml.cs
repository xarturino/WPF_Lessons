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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button mybutton = new Button();
            mybutton.Width = 200;
            mybutton.Height = 30;
            mybutton.Content = "Button2";
            grid1.Children.Add(mybutton);
        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            string text = textBox1.Text;
            if (text != "")
                MessageBox.Show(text);
        }
    }
}
