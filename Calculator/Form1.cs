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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.Focus();
            richTextBox1.Text = "0";
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "0";
            }
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                richTextBox1.Focus();
                if (richTextBox1.Text == "0")
                {
                    richTextBox1.Text = "";
                }
                richTextBox1.AppendText(((Button)sender).Text);
            }
        }

        private void negative_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            try
            {
                double num = double.Parse(richTextBox1.Text);
                num -= (num + num);
                richTextBox1.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
