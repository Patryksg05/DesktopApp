using DevExpress.DirectX.NativeInterop.Direct2D.CCW;
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
                if (isPrime2(num))
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

        private void nwd_number(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(result.Text, out int num) && num > 0)
            {
                nwd_text.Text = " ";
                nwd_text.Text = nwd(num, 4).ToString();
            }
        }

        private void sieve1(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(result.Text, out int num) && num>0)
            {
                lowerPrimeNumber(num);
            }
        }
        private void fibonacci_sequance(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(result.Text, out int num) && num>0)
            {
                String result = " ";
                for (int i = 0; i < num; i++)
                    result += fibonacci_sequance(i).ToString() + " ";
                // MessageBox.Show(result);
                fs_text.Text = result;
            }
        }

        private void sieve2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(result.Text, out int num) && num > 0)
            {
                sieveOfEratosthenes(num);
            }
        }

        private void dividers_number(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(result.Text, out int num) && num>0)
            {
                dividers(num);
            }
        }
        
        private void pow_number(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(result.Text, out int num) && num > 0)
            {
                pow_text.Text = " ";
                pow_text.Text = math_pow_function(num, 2).ToString();
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

        private int fibonacci_sequance(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return fibonacci_sequance(n - 1) + fibonacci_sequance(n - 2);
        }

        private bool isPrime2(int n)
        {
            bool prime = true;

            int i = 1;
            while (i * i <= n)
                i++;

            for(int k=2; k<i; k++)
                if(n%k==0)
                    prime = false;

            return prime;
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

            String result = "";
            for (int i = 2; i < n; i++)
                if (prime[i] == true)
                    sieveText2.Text += i.ToString() + " ";

            //result += i.ToString() + " ";
            // MessageBox.Show(result);
        }

        private int nwd(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a -= b;
                else
                    b -= a;
            return a; 
        }

        private void dividers(int n)
        {
            dividers_text.Text = " ";   
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    dividers_text.Text += i.ToString() + " ";
        }

        private long math_pow_function(int n, int x)
        {
            if (x == 0)
                return 1;
            return n*math_pow_function(n, x - 1);
        }
    }
}

/** CONVERT ZMIENNYCH   
    *  int to string => ToString()
    *  string to int => Int32.Parse(str)
 **/
