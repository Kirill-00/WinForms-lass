using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //public string Form2Text
        //{
        //    set
        //    {
        //        textBox1.Text = value;
        //    }
        //}

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public string formText
        {
            get { return textBox1.Text; }
        }
    }
}
