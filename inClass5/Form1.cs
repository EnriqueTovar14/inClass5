using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = 4.0;
            double denom = 1.0;
            double sum = 0.0;
            double.TryParse(textBox1.Text, out double userInput);
            for(int i = 1; i <= userInput; i++)
            {if (i % 2 == 1)
                    sum += num / denom;
                else
                    sum -= num / denom;

                denom += 2.0;

            }
            label2.Text = ("Approximate value of pi after " + userInput + " terms");
            label3.Text = ("= " + sum);
        }
    }
}
