using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace CalculatorForms
{
    delegate void ArithmaticOperation(int num1, int num2);
    public partial class Form1 : Form
    {
        string Fnoperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

           Calculator.CalculatorBOL cal = new CalculatorBOL();
            switch (Fnoperator)
            {
                case "+":
                    ArithmaticOperation op1 = new ArithmaticOperation(cal.Add);
                    op1(num1, num2);
                    break;
                case "-":
                    ArithmaticOperation op2 = new ArithmaticOperation(cal.Sub);
                    op2(num1, num2);
                    break;
                case "*":
                    ArithmaticOperation op3 = new ArithmaticOperation(cal.Mult);
                    op3(num1, num2);
                    break;
                case "/":
                    ArithmaticOperation op4 = new ArithmaticOperation(cal.Div);
                    op4(num1, num2);
                    break;
            }
            int result = cal.Result;
            label1.Text = result.ToString();


        }


            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            Fnoperator = comboBox1.SelectedItem.ToString();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
