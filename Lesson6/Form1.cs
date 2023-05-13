using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6
{
    public partial class Form1 : Form
    {
        Font saveFont;
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            var fontsCollection = new InstalledFontCollection();
            var font = fontsCollection.Families;
            foreach (var item in font)
            {
                chooseFont.Items.Add(item.Name);
            }
        }

        private void loadText_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files (*.txt)|*.txt";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteText_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutText_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void propertiesText_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Количество символов в строке: {richTextBox1.TextLength}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Количество символов: {richTextBox1.TextLength}";
        }

        private void setBoldText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void setItalicText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void setUnderlinedText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void textIncrease_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size + 1, richTextBox1.SelectionFont.Style);
        }

        private void textDicrease_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Size > 1)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size - 1, richTextBox1.SelectionFont.Style);
            }
        }

        private void textLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void textCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void textRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void chooseFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font((string)chooseFont.SelectedItem, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void formatPaint_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "" && formatPaint.Checked == true)
            {
                saveFont = richTextBox1.SelectionFont;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (formatPaint.Checked == true)
            {
                richTextBox1.SelectionFont = saveFont;
            }
        }

        private void chooseColor_Click(object sender, EventArgs e)
        {
            var colorCollection = new ColorDialog();
            if (colorCollection.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorCollection.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = richTextBox1.Text.LastIndexOf(textBox1.Text);

            while (start < end)
            {
                richTextBox1.Find(textBox1.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);

                richTextBox1.SelectionBackColor= Color.Red;

                start = richTextBox1.Text.IndexOf(textBox1.Text, start) + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
    }
}
