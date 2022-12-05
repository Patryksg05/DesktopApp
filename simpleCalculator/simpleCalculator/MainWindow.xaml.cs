using DevExpress.Utils.CommonDialogs.Internal;
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

        private void prime_number(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(result.Text, out int num) && num > 0)
            {
                if (isPrime(num))
                    primeText.Text = isPrime(num).ToString();
                else
                    primeText.Text = isPrime(num).ToString();
            }
        }

        private void factor_number(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(result.Text, out int num) && num > 0 && num <= 33)
            {
                factorText.Text = " ";
                factorText.Text = factor(num).ToString();
            }
            else
                factorText.Text = "CPU has problem..";
        }

        private void sieve1(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(result.Text, out int num) && num>0)
            {
                lowerPrimeNumber(num);
            }
        }

        private void sieve2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(result.Text, out int num) && num > 0)
            {
                sieveOfEratosthenes(num);
            }
        }

        private bool isPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        private int factor(int n)
        {
            int i,s;
            i = s = 1;
            while(i<=n)
            {
                s *= i;
                i++;
            }
            return s;
        }

        private void lowerPrimeNumber(int n)
        {
            List<int> prime = new List<int>();
            for (int i = 2; i < n; i++)
                if (isPrime(i))
                    prime.Add(i);

            sieveText1.Text = "";
            for (int i = 0; i < prime.Count(); i++)
                sieveText1.Text += prime[i].ToString() + " ";

        }

        private void sieveOfEratosthenes(int n)
        {
            sieveText2.Text = " ";
            bool[] prime = new bool[n + 1];
            for (int i =0; i < n; i++)
                prime[i] = true;

            for(int p=2; p*p<n; p++)
            {
                if (prime[p] == true)
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
            }

            for (int i = 2; i < n; i++)
                if (prime[i] == true)
                    sieveText2.Text += i.ToString() + " ";
        }

    }
}
