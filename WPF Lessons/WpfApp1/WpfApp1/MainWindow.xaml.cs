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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftnumber = "";
        string rightnumber = "";
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement button in LayoutRoot.Children)
            {
                if (button is Button)
                    ((Button)button).Click += Button_Click;
            }
        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            textBlock.Text += s;
            int num;
            bool result = Int32.TryParse(s, out num);
            if (result == true)
                if (operation == "")
                    leftnumber += s;
                else
                    rightnumber += s;
            else
                if(s == "=")
            {
                UpdateRightNumber();
                textBlock.Text += rightnumber;
                operation = "";
            }
            else if(s == "CLEAR")
            {
                leftnumber = "";
                rightnumber = "";
                operation = "";
                textBlock.Text = "";
            }
            else
            {
                if (rightnumber != "")
                {
                    UpdateRightNumber();
                    leftnumber = rightnumber;
                    rightnumber = "";
                }
                operation = s;
            }
        }

        private void UpdateRightNumber()
        {
            int num1 = Int32.Parse(leftnumber);
            int num2 = Int32.Parse(rightnumber);
            // И выполняем операцию
            switch (operation)
            {
                case "+":
                    rightnumber = (num1 + num2).ToString();
                    break;
                case "-":
                    rightnumber = (num1 - num2).ToString();
                    break;
                case "*":
                    rightnumber = (num1 * num2).ToString();
                    break;
                case "/":
                    rightnumber = (num1 / num2).ToString();
                    break;
            }
        }
    }
}