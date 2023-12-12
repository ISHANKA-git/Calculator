using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string operation = "";
        double result_Value = 0;
        bool is_Operation_Performed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || is_Operation_Performed) 
            {
                textBox1.Clear();
            }

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }

            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }

            
            is_Operation_Performed = false;

        }

        private void operation_Performed(object sender, EventArgs e)
        {
            if(result_Value != 0)
            {
                button19.PerformClick();
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(textBox1.Text);
                label1.Text = result_Value + operation;
                is_Operation_Performed = true;
            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                result_Value = double.Parse(textBox1.Text);
                label1.Text = result_Value + operation;
                is_Operation_Performed = true;
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result_Value = 0;
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result_Value + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result_Value - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result_Value * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result_Value / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    }
}
