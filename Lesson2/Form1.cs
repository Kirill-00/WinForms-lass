using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Tick += new EventHandler(ShowTime);
            timer1.Interval = 10;
            timer1.Start();
        }
        public void ShowTime(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
        private void addSizeText_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size + 1);
        }
        private void subSizeText_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size - 1);
        }
        private void clearBth_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}