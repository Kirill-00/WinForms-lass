using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessson4
{
    public partial class Form1 : Form
    {
        Lesson4.Form2 form2 = new Lesson4.Form2();
        public Form1()
        {
            InitializeComponent();
            form2.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (form2.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Add(form2.formText);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
