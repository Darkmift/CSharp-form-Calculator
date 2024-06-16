using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = this.calcInputs(txtNumber1.Text, txtNumber2.Text).ToString();
        }

        private int calcInputs(string textNum1, string textNum2)
        {
            return (int.Parse(textNum1) + int.Parse(textNum2));
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void onOperatorClick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void onNumber_Clicked(object button, EventArgs e)
        {
            TextBox t1 = txtNumber1;
            TextBox t2 = txtNumber2;
            ComboBox operatorBox = comboBox1;
            TextBox target = t1;
            string b1Text = ((Button)button).Text;

            target = string.IsNullOrEmpty(t1.Text) && string.IsNullOrEmpty(comboBox1.Text) ? t2 : t1;
            if (string.IsNullOrEmpty(target.Text) || target.Text.Contains(".") && b1Text == ".") return;

            target.Text += b1Text;
        }
    }
}
