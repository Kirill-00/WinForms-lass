using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4_1
{
    public partial class Form1 : Form
    {
        Good good;
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            good = new Good();
            Form2 openForm = new Form2(good, true);
            if (openForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(good);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            int i = listBox1.SelectedIndex;
            good = (Good)listBox1.Items[i];
            Form2 editForm = new Form2(good, false);
            editForm.ShowDialog();
            listBox1.Items.RemoveAt(i);
            listBox1.Items.Insert(i, good);
            listBox1.SelectedIndex = i;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Load_Click(object sender, EventArgs e)
        {

        }
    }
}
