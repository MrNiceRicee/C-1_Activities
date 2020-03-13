using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment7
{
    public partial class Form1 : Form
    {
        private Random random = new Random();


        public int TwoIntSum(int number1, int number2)
        {
            return (number1+number2);
        }

        public double FiveDoublesGetAverage(double num1, double num2, double num3, double num4, double num5)
        {
            return (num1+num2+num3+num4+num5)/5.00;

        }

        public int TwoRandomInts()
        {
            int xx1 = random.Next(1000);    
            int xx2 = random.Next(1000);
            return (xx1+xx2);
        }

        public Boolean TripleDivisibleByThree(int number1, int number2, int number3)
        {
            if ((number1+number2+number3)%3==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ShorterOfTwoStrings(String word1, String word2)
        {
            var words = new String[] {word1, word2 };
            return (words.OrderByDescending(s=>s.Length).Last());
        }

        public double BiggestInDoubleArray(double[] DoubleArray)
        {
            //var biggest = DoubleArray.Max(x=>x);
            //return biggest;
            return (DoubleArray.Max(x=>x));
        }

        public double[] GenerateFiftyNumbers()
        {
            double[] fifty = new double[50];
            for (int i = 0; i < 50; i++)        //50 loops
            {
                fifty[i] = random.NextDouble() * random.Next(1000);
            }
            return fifty;
        }

        public Boolean SameBool(Boolean first, Boolean second)
        {
            if (first.Equals(second))
            {
                return true;
            }else
            {
                return false;
            }
        }

        public double IntTimesDouble(int NumberInt, double NumberDouble)
        {
            return (NumberInt*NumberDouble);
        }

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(IntTimesDouble(8,10.5));
        }
    }
}
