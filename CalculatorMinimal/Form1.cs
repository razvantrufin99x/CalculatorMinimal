using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorMinimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = 0;

                int op = comboBox1.SelectedIndex;


                switch (op)
                {
                    case 0: c = a + b; break;
                    case 1: c = a - b; break;
                    case 2: c = a * b; break;
                    case 3: c = a / b; break;

                }

                textBox3.Text = c.ToString();
            }
            catch { }
        }
    }
}
