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

namespace CalculatorWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            labelTime.Content = DateTime.Now.Date;
        }
        float a, b;
        int operation = 0;
        bool plusMinus = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 6;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 7;
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 8;
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + 9;
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (!TextBox.Text.Contains('.'))
            {
                TextBox.Text = TextBox.Text + ".";
            }
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (plusMinus == true)
            {
                TextBox.Text = "-" + TextBox.Text;
                plusMinus = false;
            }
            else if (plusMinus == false)
            {
                TextBox.Text = TextBox.Text.Replace("-", "");
                plusMinus = true;
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            calc();
            label.Content = "";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox.Text);
            TextBox.Clear();
            operation = 1;
            label.Content = a.ToString() + "+";
            plusMinus = true;

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox.Text);
            TextBox.Clear();
            operation = 2;
            label.Content = a.ToString() + "-";
            plusMinus = true;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox.Text);
            TextBox.Clear();
            operation = 3;
            label.Content = a.ToString() + "*";
            plusMinus = true;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox.Text);
            TextBox.Clear();
            operation = 4;
            label.Content = a.ToString() + "/";
            plusMinus = true;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            TextBox.Clear();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            int length = TextBox.Text.Length-1;
            string text = TextBox.Text;
            TextBox.Clear();
            for (int i = 0; i < length; i++)
            {
                TextBox.Text = TextBox.Text + text[i];
            }
        }

        private void calc()
        {
            switch (operation)
            {
                case 1:
                    b = a + float.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    break;
                case 4:

                    b = a / float.Parse(TextBox.Text);
                    TextBox.Text = b.ToString();
                    break;
                
            }


        }


    }
}
