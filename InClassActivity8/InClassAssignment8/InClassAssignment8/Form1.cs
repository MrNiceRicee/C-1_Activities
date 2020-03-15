using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment8
{
    public partial class Form1 : Form
    {



        public double CaloriesFromFat(double FatGrams)
        {
            return (FatGrams*9);
        }

        public double CaloriesFromCarbs(double CarbsGrams)
        {
            return (CarbsGrams*4);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
