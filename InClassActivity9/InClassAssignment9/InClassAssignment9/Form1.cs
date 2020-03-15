using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InClassAssignment9
{
    public partial class Form1 : Form
    {

        public void checkmethod1()
        {
            //make some sets    
            List<int> A = new List<int>();          //changed from set to List<int> A = new List<int>()
            List<int> B = new List<int>();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.Add(r.Next(4));           //changed from addelements to Add
                B.Add(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.Union(B));      //changed from union to Union

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
