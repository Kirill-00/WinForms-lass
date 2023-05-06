using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stopBtn.Enabled = false;
            timer1.Tick += new EventHandler(showTimer);
        }

        private void showTimer(object sender, EventArgs e)
        {
            numericUpDown1.Value -= 0.016m;
            if (numericUpDown1.Value <= 0)
            {
                timer1.Stop();
                stopBtn.Enabled = false;
                MessageBox.Show("Таймер отработал", "Таймер");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Произошла ошибка при доступе к файлу!", "Ошибка", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            if (result == DialogResult.Abort)
            {
                MessageBox.Show("Вы нажали кнопку прервать");
            }
            else if (result == DialogResult.Retry)
            {
                MessageBox.Show("Вы нажали кнопку повтора");
            }
            else if (result == DialogResult.Ignore)
            {
                MessageBox.Show("Вы нажали на кнопку пропустить");
            }
        }

        private string coordMouse(MouseEventArgs e)
        {
            return $"Координаты мыши: x = {e.X.ToString()}\ny ={ e.Y.ToString()}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string message = coordMouse(e);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string message = "Произошол клик мыши\n";
            message += coordMouse(e as MouseEventArgs);
            MessageBox.Show(message, "Событие мыши", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void startbtn_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Количество секунд должно быть больше нуля!");
            }
            timer1.Start();
            stopBtn.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopBtn.Enabled=false;
        }
    }
}
