using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculate
{
    public partial class calculator : Form
    {
        ICalculator calculate;
        public calculator()
        {
            InitializeComponent();
            calculate = new Calculator();

        }

        private void Button_Multiple_Click(object sender, EventArgs e)
        {
            if (validate_input())
            {
                int result = calculate.Multiple((int)txt_num1.Value, (int)txt_num2.Value);
                resultBox.Text = result.ToString();
            }

        }

        private void Button_Divide_Click(object sender, EventArgs e)
        {
            if (validate_input())
            {
                int result = calculate.Divide((int)txt_num1.Value, (int)txt_num2.Value);
                resultBox.Text = result.ToString();
            }
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            if (validate_input())
            {
                int result = calculate.Plus((int)txt_num1.Value, (int)txt_num2.Value);
                resultBox.Text = result.ToString();
            }
        }

        private void Button_Minus_click(object sender, EventArgs e)
        {
            if (validate_input())
            {
                int result = calculate.Minus((int)txt_num1.Value, (int)txt_num2.Value);
                resultBox.Text = result.ToString();
            }
        }

        private bool validate_input()
        {
            

            if(txt_num1.Value == 0)
            {
                MessageBox.Show("لطفا عدد اول را وارد کنید");
                return false;
            }
            if(txt_num2.Value == 0)
            {
                MessageBox.Show("لطفا عدد دوم را وارد کنید");
                return false;
            }
            return true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
