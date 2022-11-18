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

namespace Wpf_Chemeris_PR2._2._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                        textBox1.Text = textBox1.Text + 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            //В душе не чаю как делать, у меня кредит ипотека, рил проблем много
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                tb.Text = "Error!";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                //Ошибка    
            }

            op = tb.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            if (op == "+")
            {
                tb.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                tb.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text += "=" + (op1 * op2);
            }
            else
            {
                tb.Text += "=" + (op1 / op2);
            }
        }
    }
