namespace TestTaskDb
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.профильToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem,
            this.stepsToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.таблицыToolStripMenuItem.Text = "таблицы";
            // 
            // modesToolStripMenuItem
            // 
            this.modesToolStripMenuItem.Name = "modesToolStripMenuItem";
            this.modesToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.modesToolStripMenuItem.Text = "Modes";
            this.modesToolStripMenuItem.Click += new System.EventHandler(this.modesToolStripMenuItem_Click);
            // 
            // stepsToolStripMenuItem
            // 
            this.stepsToolStripMenuItem.Name = "stepsToolStripMenuItem";
            this.stepsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stepsToolStripMenuItem.Text = "Steps ";
            this.stepsToolStripMenuItem.Click += new System.EventHandler(this.stepsToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьЗаписьToolStripMenuItem,
            this.зменитьЗаписьToolStripMenuItem,
            this.импортExcelToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.действияToolStripMenuItem.Text = "действия";
            // 
            // вставитьЗаписьToolStripMenuItem
            // 
            this.вставитьЗаписьToolStripMenuItem.Name = "вставитьЗаписьToolStripMenuItem";
            this.вставитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вставитьЗаписьToolStripMenuItem.Text = "вставить запись";
            this.вставитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.вставитьЗаписьToolStripMenuItem_Click);
            // 
            // зменитьЗаписьToolStripMenuItem
            // 
            this.зменитьЗаписьToolStripMenuItem.Name = "зменитьЗаписьToolStripMenuItem";
            this.зменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.зменитьЗаписьToolStripMenuItem.Text = "изменить запись";
            this.зменитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.зменитьЗаписьToolStripMenuItem_Click);
            // 
            // импортExcelToolStripMenuItem
            // 
            this.импортExcelToolStripMenuItem.Name = "импортExcelToolStripMenuItem";
            this.импортExcelToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.импортExcelToolStripMenuItem.Text = "импорт Excel";
            this.импортExcelToolStripMenuItem.Click += new System.EventHandler(this.импортExcelToolStripMenuItem_Click);
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem,
            this.авторизацияToolStripMenuItem});
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.профильToolStripMenuItem.Text = "профиль";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.регистрацияToolStripMenuItem.Text = "регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.авторизацияToolStripMenuItem.Text = "авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "удалить запись №";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 198);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 235);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(489, 274);
            this.MinimumSize = new System.Drawing.Size(489, 274);
            this.Name = "MainForm";
            this.Text = "Программа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зменитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортExcelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

