namespace Lesson4_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 468);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(462, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать товар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(462, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить товар";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Del_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 612);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(462, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Отчистить список";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 654);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Сохранть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Save_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(248, 654);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(226, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "Загрузить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 694);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Каталог товаров";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

