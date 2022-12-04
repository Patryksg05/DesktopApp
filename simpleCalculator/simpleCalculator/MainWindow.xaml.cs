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

namespace simpleCalculator
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

        private void primeNumber(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(number.Text, out int num) && num>=0)
            {
                if(isPrime(num))
                {
                    result.Text = isPrime(num).ToString();
                    lowerPrime(num);
                }
                else
                {
                    result.Text = isPrime(num).ToString();
                }
            }
            else
            {
                MessageBox.Show("FILL CORRECTLY", "ERROOOR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Najmniejszymi liczbami pierwszymi są 2, 3, 5, 7, 11, 13, 17, 19
        private bool isPrime(int num)
        {
            if (num < 2)
                return false;

            for(int i=2; i<num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        private void lowerPrime(int n)
        {
            List<int> primeNumbers = new List<int>();
            for(int i=2; i<n; i++)
            {
                if (isPrime(i))
                    primeNumbers.Add(i);
                    
            }

            smaller.Text = " ";
    
            for(int i=0; i<primeNumbers.Count(); i++)
            {
                smaller.Text += primeNumbers[i].ToString() + " ";
            }

        }

        private void factorialNumber(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(number.Text, out int num))
            {
                result.Text = factorial(num).ToString();
            }
        }

        private int factorial(int n)
        {
            int i, s;
            i = s = 1;

            while(n>=i)
            {
                s *= i;
                i++;
            }
            return s;
        }
    }
}
