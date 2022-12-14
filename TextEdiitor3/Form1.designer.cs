namespace TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.выделениеТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьТекстЖирнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьТекстКурсивомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подчеркнутьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйЦветТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.center = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // просмотретьФайлToolStripMenuItem
            // 
            this.просмотретьФайлToolStripMenuItem.Name = "просмотретьФайлToolStripMenuItem";
            this.просмотретьФайлToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(35, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(922, 443);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = " ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(208, 37);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(234, 36);
            this.left.TabIndex = 5;
            this.left.Text = "Выравнить по левому краю";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(664, 37);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(239, 36);
            this.right.TabIndex = 6;
            this.right.Text = "Выравнить по правому краю";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // выделениеТекстаToolStripMenuItem
            // 
            this.выделениеТекстаToolStripMenuItem.Name = "выделениеТекстаToolStripMenuItem";
            this.выделениеТекстаToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // сделатьТекстЖирнымToolStripMenuItem
            // 
            this.сделатьТекстЖирнымToolStripMenuItem.Name = "сделатьТекстЖирнымToolStripMenuItem";
            this.сделатьТекстЖирнымToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // выделитьТекстКурсивомToolStripMenuItem
            // 
            this.выделитьТекстКурсивомToolStripMenuItem.Name = "выделитьТекстКурсивомToolStripMenuItem";
            this.выделитьТекстКурсивомToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // подчеркнутьТекстToolStripMenuItem
            // 
            this.подчеркнутьТекстToolStripMenuItem.Name = "подчеркнутьТекстToolStripMenuItem";
            this.подчеркнутьТекстToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // стандартныйШрифтToolStripMenuItem
            // 
            this.стандартныйШрифтToolStripMenuItem.Name = "стандартныйШрифтToolStripMenuItem";
            this.стандартныйШрифтToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // красныйТекстToolStripMenuItem
            // 
            this.красныйТекстToolStripMenuItem.Name = "красныйТекстToolStripMenuItem";
            this.красныйТекстToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // зеленыйТекстToolStripMenuItem
            // 
            this.зеленыйТекстToolStripMenuItem.Name = "зеленыйТекстToolStripMenuItem";
            this.зеленыйТекстToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // синийТекстToolStripMenuItem
            // 
            this.синийТекстToolStripMenuItem.Name = "синийТекстToolStripMenuItem";
            this.синийТекстToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // стандартныйЦветТекстаToolStripMenuItem
            // 
            this.стандартныйЦветТекстаToolStripMenuItem.Name = "стандартныйЦветТекстаToolStripMenuItem";
            this.стандартныйЦветТекстаToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // center
            // 
            this.center.Location = new System.Drawing.Point(448, 37);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(210, 36);
            this.center.TabIndex = 9;
            this.center.Text = "Выравнить по ширине";
            this.center.UseVisualStyleBackColor = true;
            this.center.Click += new System.EventHandler(this.center_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.просмотретьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.выйтиToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // выйтиToolStripMenuItem1
            // 
            this.выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
            this.выйтиToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.выйтиToolStripMenuItem1.Text = "Выйти";
            this.выйтиToolStripMenuItem1.Click += new System.EventHandler(this.выйтиToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Шрифт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Цвет ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(993, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.center);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text editor from Sanek228";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьФайлToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.ToolStripMenuItem выделениеТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьТекстЖирнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьТекстКурсивомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подчеркнутьТекстToolStripMenuItem;
        private System.Windows.Forms.Button center;
        private System.Windows.Forms.ToolStripMenuItem красныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйЦветТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйШрифтToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

