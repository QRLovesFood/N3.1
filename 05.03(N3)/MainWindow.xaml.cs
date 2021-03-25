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

namespace _05._03_N3_
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

        private void BTplus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = double.Parse(TX1.Text) + double.Parse(TX2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = double.Parse(TX1.Text) - double.Parse(TX2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = double.Parse(TX1.Text) * double.Parse(TX2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = double.Parse(TX1.Text) / double.Parse(TX2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = (double.Parse(TX1.Text) * double.Parse(TX2.Text)) / 100 + "%";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = Math.Sin(double.Parse(TX1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }          
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = Math.Cos(double.Parse(TX1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }      
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = Math.Log(double.Parse(TX1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }          
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = Math.Pow(double.Parse(TX1.Text), 2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }           
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = Math.Pow(double.Parse(TX1.Text), double.Parse(TX2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }          
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                TXResult.Content = Math.Sqrt(double.Parse(TX1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введи число лол");
            }         
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TX1.Clear();
            TX2.Clear();
            TXResult.Content = 0;
        }

        private void TX1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890,".IndexOf(e.Text) < 0;
        }
    }
}
