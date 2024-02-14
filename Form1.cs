using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2hw2sp
{

    public partial class Form1 : Form
    {
        private Thread primeThread;
        private Thread fibonacciThread;
        private bool isPrimesRunning = false;
        private bool isFibonacciRunning = false;
        private bool stopPrimeThread = false;
        private bool stopFibonacciThread = false;
        public Form1()
        {
            InitializeComponent();
            btnStopPrimes.Enabled = true;
            btnGenerateFibonacci.Enabled = true;
            btnStopFibonacci.Enabled = true;

            btnResumeFibonacci.Enabled = true;
            btnRestartPrimes.Enabled = true;

            btnResumeFibonacci.Click += btnResumeFibonacci_Click;
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (!isPrimesRunning)
            {
                int lowerBound = string.IsNullOrEmpty(txtLowerBound.Text) ? 2 : int.Parse(txtLowerBound.Text);
                int upperBound = string.IsNullOrEmpty(txtUpperBound.Text) ? int.MaxValue : int.Parse(txtUpperBound.Text);

                primeThread = new Thread(() => GeneratePrimeNumbers(lowerBound, upperBound));
                primeThread.Start();
                isPrimesRunning = true;
                Console.WriteLine("Start button clicked");
            }

            if (!isFibonacciRunning)
            {
                fibonacciThread = new Thread(GenerateFibonacci);
                fibonacciThread.Start();
                isFibonacciRunning = true;
            }
        }
       
        
        private void GeneratePrimeNumbers(int lowerBound, int upperBound)
        {
            List<int> primes = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                    UpdateListBox(lstPrimes, primes);
                }
            }
        }

        private void UpdateListBox(ListBox lstPrimes, List<int> numbers)
        {
            if (lstPrimes.InvokeRequired)
            {
                lstPrimes.Invoke(new Action<ListBox, List<int>>(UpdateListBox), lstPrimes, numbers);
            }
            else
            {
                lstPrimes.Items.Clear();
                foreach (int number in numbers)
                {
                    lstPrimes.Items.Add(number.ToString());
                }
            }
        }

        private bool IsPrime(int i)
        {
            if (i <= 1)
                return false;
            if (i == 2)
                return true;
            if (i % 2 == 0)
                return false;

            int boundary = (int)Math.Floor(Math.Sqrt(i));

            for (int j = 3; j <= boundary; j += 2)
            {
                if (i % j == 0)
                    return false;
            }

            return true;
        }

        private void btnStopPrimes_Click(object sender, EventArgs e)
        {
            if (primeThread != null && primeThread.IsAlive && primeThread.ThreadState != ThreadState.Suspended)
            {
                primeThread.Abort();
                isPrimesRunning = false;
            }

            if (fibonacciThread != null && fibonacciThread.IsAlive && fibonacciThread.ThreadState != ThreadState.Suspended)
            {
                fibonacciThread.Abort();
                isFibonacciRunning = false;
            }
        }
        private ManualResetEvent pauseEvent = new ManualResetEvent(true);
        private void GenerateFibonacci()
        {
            List<int> fibonacciNumbers = new List<int>();
            int a = 0;
            int b = 1;

            while (true)
            {
                pauseEvent.WaitOne(); 

                int temp = a;
                a = b;
                b = temp + b;
                fibonacciNumbers.Add(temp);

                UpdateListBox(lstFibonacci, fibonacciNumbers);
                Thread.Sleep(500); 
            }
        }
        private void btnPauseFibonacci_Click(object sender, EventArgs e)
        {
            pauseEvent.Reset(); 
            
            btnResumeFibonacci.Enabled = true;
        }

        private void btnResumeFibonacci_Click(object sender, EventArgs e)
        {
            pauseEvent.Set(); 
            
            btnResumeFibonacci.Enabled = false;
        }
      
    }
}

