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
            Random r = new Random();

            return (+);
        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
