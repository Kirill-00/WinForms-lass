using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"Value: {progressBar1.Value}";
            timer2.Start();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                var selectedItems = listBox1.SelectedItems;
                if (selectedItems.Count > 0)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listBox1.Items.Remove(selectedItems[i]);
                }
            }
        }
        private void addBtnChkBox_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                checkedListBox1.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }
        private void delBtnChkBox_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems != null)
            {
                var checkedItems = checkedListBox1.CheckedItems;
                if (checkedItems.Count > 0)
                {
                    for (int i = checkedItems.Count - 1; i >= 0; i--)
                        checkedListBox1.Items.Remove(checkedItems[i]);
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Text.ToLower() == comboBox1.Items[i].ToString().ToLower())
                {
                    textBox3.Text = comboBox1.Items[i].ToString();
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.PerformStep();
                label1.Text = $"Value: {progressBar1.Value.ToString()}";
                this.Update();
                Thread.Sleep(100);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void UpdateColor()
        {
            Color color = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = color;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
