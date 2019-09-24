using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            listBoxFizzBuzz.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                bool mult3 = false, mult5 = false;
                if (i % 3 == 0) mult3 = true;
                if (i % 5 == 0) mult5 = true;
                if (mult3 && mult5) listBoxFizzBuzz.Items.Add("FizzBuzz");
                else if (mult3) listBoxFizzBuzz.Items.Add("Fizz");
                else if (mult5) listBoxFizzBuzz.Items.Add("Buzz");
                else listBoxFizzBuzz.Items.Add(i + "");
            }
        }
    }
}
