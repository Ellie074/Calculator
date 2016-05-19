using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.OneArgument;
using WindowsFormsApplication3.TwoArguments;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateTwo(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(first, second);
            textBox3.Text = result.ToString();
        }

        private void CalculateOne(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
          
            IOneCalculator calculator = CalculatorFactoryOne.CreateCalculatorOne(((Button)sender).Name);
            double result = calculator.Calculate(first);
            textBox3.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
