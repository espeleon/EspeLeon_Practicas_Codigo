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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


      


        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            Resta();
            Num1.Clear();
            Num2.Clear();
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            Suma();
            Num1.Clear();
            Num2.Clear();
        }

        private void Suma()
        {
            var numText = Num1.Text;
            var num1 = 0.0;

            try
            {
                num1 = GetNumber(numText);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = Num2.Text;
            var num2 = 0.0;

            try
            {
                num2 = GetNumber(num2Text);
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.Message);
                return;
            }

            var sumResult = num1 + num2;
            // mostramos el resultado

            MessageBox.Show("El resultado es: " + sumResult);
        }

        public void Resta()
        {
            var numText = Num1.Text;
            var num1 = 0.0;

            try
            {
                num1 = GetNumber(numText);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            var num2Text = Num2.Text;
            var num2 = 0.0;

            try
            {
                num2 = GetNumber(num2Text);
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.Message);
                return;
            }

            var sumResult = num1 - num2;
            // mostramos el resultado

            MessageBox.Show("El resultado es: " + sumResult);



        }


        private double GetNumber(string text)
        {
            text = text.Replace(".", ",");

            try
            {
                return double.Parse(text);
            }
            catch (Exception)
            {
                throw new Exception("El número {text} tiene un formato incorrecto.");
            }
        }

        
    }
}