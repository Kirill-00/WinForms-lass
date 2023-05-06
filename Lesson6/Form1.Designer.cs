namespace Lesson6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadText = new System.Windows.Forms.ToolStripMenuItem();
            this.saveText = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.cutText = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesText = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setBoldText = new System.Windows.Forms.ToolStripButton();
            this.setItalicText = new System.Windows.Forms.ToolStripButton();
            this.setUnderlinedText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.textIncrease = new System.Windows.Forms.ToolStripButton();
            this.textDicrease = new System.Windows.Forms.ToolStripButton();
            this.chooseFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.textLeft = new System.Windows.Forms.ToolStripButton();
            this.textCenter = new System.Windows.Forms.ToolStripButton();
            this.textRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.formatPaint = new System.Windows.Forms.ToolStripButton();
            this.chooseColor = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadText,
            this.saveText,
            this.CopyText,
            this.pasteText,
            this.cutText,
            this.propertiesText});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.Size = new System.Drawing.Size(165, 148);
            // 
            // loadText
            // 
            this.loadText.Name = "loadText";
            this.loadText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadText.Size = new System.Drawing.Size(164, 24);
            this.loadText.Text = "Load";
            this.loadText.Click += new System.EventHandler(this.loadText_Click);
            // 
            // saveText
            // 
            this.saveText.Name = "saveText";
            this.saveText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveText.Size = new System.Drawing.Size(164, 24);
            this.saveText.Text = "Save";
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // CopyText
            // 
            this.CopyText.Name = "CopyText";
            this.CopyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyText.Size = new System.Drawing.Size(164, 24);
            this.CopyText.Text = "Copy";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // pasteText
            // 
            this.pasteText.Name = "pasteText";
            this.pasteText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteText.Size = new System.Drawing.Size(164, 24);
            this.pasteText.Text = "Paste";
            this.pasteText.Click += new System.EventHandler(this.pasteText_Click);
            // 
            // cutText
            // 
            this.cutText.Name = "cutText";
            this.cutText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutText.Size = new System.Drawing.Size(164, 24);
            this.cutText.Text = "Cut";
            this.cutText.Click += new System.EventHandler(this.cutText_Click);
            // 
            // propertiesText
            // 
            this.propertiesText.Name = "propertiesText";
            this.propertiesText.Size = new System.Drawing.Size(164, 24);
            this.propertiesText.Text = "Properties";
            this.propertiesText.Click += new System.EventHandler(this.propertiesText_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton8,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.setBoldText,
            this.setItalicText,
            this.setUnderlinedText,
            this.toolStripSeparator3,
            this.textIncrease,
            this.textDicrease,
            this.chooseFont,
            this.toolStripSeparator4,
            this.textLeft,
            this.textCenter,
            this.textRight,
            this.toolStripSeparator5,
            this.formatPaint,
            this.chooseColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 34);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Load (Ctrl + O)";
            this.toolStripButton1.Click += new System.EventHandler(this.loadText_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Save (Ctrl + S)";
            this.toolStripButton2.Click += new System.EventHandler(this.saveText_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Lesson6.Properties.Resources.content_copy_FILL0_wght400_GRAD0_opsz48;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton8.Text = "toolStripButton3";
            this.toolStripButton8.ToolTipText = "Copy (Ctrl + C)";
            this.toolStripButton8.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Lesson6.Properties.Resources.content_paste_FILL0_wght400_GRAD0_opsz48;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Paste (Ctrl + V)";
            this.toolStripButton4.Click += new System.EventHandler(this.pasteText_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Lesson6.Properties.Resources.content_cut_FILL0_wght400_GRAD0_opsz48;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.ToolTipText = "Cut (Ctrl + X)";
            this.toolStripButton5.Click += new System.EventHandler(this.cutText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // setBoldText
            // 
            this.setBoldText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setBoldText.Image = global::Lesson6.Properties.Resources.format_bold_FILL0_wght400_GRAD0_opsz48;
            this.setBoldText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setBoldText.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.setBoldText.Name = "setBoldText";
            this.setBoldText.Size = new System.Drawing.Size(29, 24);
            this.setBoldText.Text = "toolStripButton6";
            this.setBoldText.ToolTipText = "Bold";
            this.setBoldText.Click += new System.EventHandler(this.setBoldText_Click);
            // 
            // setItalicText
            // 
            this.setItalicText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setItalicText.Image = global::Lesson6.Properties.Resources.format_italic_FILL0_wght400_GRAD0_opsz48;
            this.setItalicText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setItalicText.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.setItalicText.Name = "setItalicText";
            this.setItalicText.Size = new System.Drawing.Size(29, 24);
            this.setItalicText.Text = "toolStripButton7";
            this.setItalicText.ToolTipText = "Italic";
            this.setItalicText.Click += new System.EventHandler(this.setItalicText_Click);
            // 
            // setUnderlinedText
            // 
            this.setUnderlinedText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setUnderlinedText.Image = global::Lesson6.Properties.Resources.format_underlined_FILL0_wght400_GRAD0_opsz48;
            this.setUnderlinedText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setUnderlinedText.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.setUnderlinedText.Name = "setUnderlinedText";
            this.setUnderlinedText.Size = new System.Drawing.Size(29, 24);
            this.setUnderlinedText.Text = "toolStripButton9";
            this.setUnderlinedText.ToolTipText = "Underline";
            this.setUnderlinedText.Click += new System.EventHandler(this.setUnderlinedText_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // textIncrease
            // 
            this.textIncrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textIncrease.Image = global::Lesson6.Properties.Resources.text_increase_FILL0_wght400_GRAD0_opsz48;
            this.textIncrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textIncrease.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.textIncrease.Name = "textIncrease";
            this.textIncrease.Size = new System.Drawing.Size(29, 24);
            this.textIncrease.Text = "toolStripButton10";
            this.textIncrease.ToolTipText = "Text Increase";
            this.textIncrease.Click += new System.EventHandler(this.textIncrease_Click);
            // 
            // textDicrease
            // 
            this.textDicrease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textDicrease.Image = global::Lesson6.Properties.Resources.text_decrease_FILL0_wght400_GRAD0_opsz48;
            this.textDicrease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textDicrease.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.textDicrease.Name = "textDicrease";
            this.textDicrease.Size = new System.Drawing.Size(29, 24);
            this.textDicrease.Text = "toolStripButton11";
            this.textDicrease.ToolTipText = "Text Dicrease";
            this.textDicrease.Click += new System.EventHandler(this.textDicrease_Click);
            // 
            // chooseFont
            // 
            this.chooseFont.Name = "chooseFont";
            this.chooseFont.Size = new System.Drawing.Size(121, 34);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // textLeft
            // 
            this.textLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textLeft.Image = global::Lesson6.Properties.Resources.format_align_left_FILL0_wght400_GRAD0_opsz48;
            this.textLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textLeft.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.textLeft.Name = "textLeft";
            this.textLeft.Size = new System.Drawing.Size(29, 24);
            this.textLeft.Text = "toolStripButton12";
            this.textLeft.ToolTipText = "Align Left";
            this.textLeft.Click += new System.EventHandler(this.textLeft_Click);
            // 
            // textCenter
            // 
            this.textCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textCenter.Image = global::Lesson6.Properties.Resources.format_align_center_FILL0_wght400_GRAD0_opsz48;
            this.textCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textCenter.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.textCenter.Name = "textCenter";
            this.textCenter.Size = new System.Drawing.Size(29, 24);
            this.textCenter.Text = "toolStripButton13";
            this.textCenter.ToolTipText = "Align Center";
            this.textCenter.Click += new System.EventHandler(this.textCenter_Click);
            // 
            // textRight
            // 
            this.textRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textRight.Image = global::Lesson6.Properties.Resources.format_align_right_FILL0_wght400_GRAD0_opsz48;
            this.textRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textRight.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.textRight.Name = "textRight";
            this.textRight.Size = new System.Drawing.Size(29, 24);
            this.textRight.Text = "toolStripButton14";
            this.textRight.ToolTipText = "Align Right";
            this.textRight.Click += new System.EventHandler(this.textRight_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // formatPaint
            // 
            this.formatPaint.CheckOnClick = true;
            this.formatPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.formatPaint.Image = global::Lesson6.Properties.Resources.format_paint_FILL0_wght400_GRAD0_opsz48;
            this.formatPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formatPaint.Name = "formatPaint";
            this.formatPaint.Size = new System.Drawing.Size(29, 31);
            this.formatPaint.Text = "toolStripButton6";
            this.formatPaint.ToolTipText = "Format Text Brush";
            this.formatPaint.Click += new System.EventHandler(this.formatPaint_Click);
            // 
            // chooseColor
            // 
            this.chooseColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseColor.Image = global::Lesson6.Properties.Resources.palette_FILL0_wght400_GRAD0_opsz48;
            this.chooseColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseColor.Name = "chooseColor";
            this.chooseColor.Size = new System.Drawing.Size(29, 31);
            this.chooseColor.Text = "toolStripButton6";
            this.chooseColor.ToolTipText = "Color Palette";
            this.chooseColor.Click += new System.EventHandler(this.chooseColor_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(698, 342);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 426);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.contextMenuStrip2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loadText;
        private System.Windows.Forms.ToolStripMenuItem saveText;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripMenuItem pasteText;
        private System.Windows.Forms.ToolStripMenuItem cutText;
        private System.Windows.Forms.ToolStripMenuItem propertiesText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton setBoldText;
        private System.Windows.Forms.ToolStripButton setItalicText;
        private System.Windows.Forms.ToolStripButton setUnderlinedText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton textIncrease;
        private System.Windows.Forms.ToolStripButton textDicrease;
        private System.Windows.Forms.ToolStripComboBox chooseFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton textLeft;
        private System.Windows.Forms.ToolStripButton textCenter;
        private System.Windows.Forms.ToolStripButton textRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton formatPaint;
        private System.Windows.Forms.ToolStripButton chooseColor;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

