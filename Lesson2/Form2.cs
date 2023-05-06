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

namespace Lesson2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strMessage = $"ФИО: {textBox1.Text} {textBox2.Text} {textBox2.Text}\n";
            strMessage += $"Дата рождения: {dateTimePicker1.Value.ToLongDateString()}\n";
            if (radioButton1.Checked == true)
            {
                strMessage += "Пол: мужской\n";
            }
            else { strMessage += "Пол: женский\n"; }
            strMessage += $"Место проживания: {textBox4.Text}, {textBox5.Text}\n";
            strMessage += $"Телефон: {textBox6.Text}\n";
            strMessage += $"Электронная почта: {textBox7.Text}\n";

            MessageBox.Show(strMessage, "Анкетные данные");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool filled = groupBox1.Controls.OfType<TextBox>().All(textBox => textBox.Text != "");

            if (filled)
            {
                MessageBox.Show("Все поля заполнены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1 != null) textBox2.Enabled = true;
            toolStripProgressBar1.Value = 1;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2 != null) textBox3.Enabled = true;
            toolStripProgressBar1.Value = 2;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3 != null) textBox4.Enabled = true;
            toolStripProgressBar1.Value = 3;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4 != null) textBox5.Enabled = true;
            toolStripProgressBar1.Value = 4;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5 != null) textBox6.Enabled = true;
            toolStripProgressBar1.Value = 5;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6 != null) textBox7.Enabled = true;
            toolStripProgressBar1.Value = 6;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 7;
        }
    }
}