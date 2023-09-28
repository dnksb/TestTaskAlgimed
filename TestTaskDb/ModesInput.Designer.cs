namespace TestTaskDb
{
    partial class ModesInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ModeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxUsedTips = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxBottleNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(15, 26);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(112, 20);
            this.ID.TabIndex = 29;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModeName
            // 
            this.ModeName.Location = new System.Drawing.Point(15, 66);
            this.ModeName.Name = "ModeName";
            this.ModeName.Size = new System.Drawing.Size(112, 20);
            this.ModeName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // MaxUsedTips
            // 
            this.MaxUsedTips.Location = new System.Drawing.Point(15, 146);
            this.MaxUsedTips.Name = "MaxUsedTips";
            this.MaxUsedTips.Size = new System.Drawing.Size(112, 20);
            this.MaxUsedTips.TabIndex = 18;
            this.MaxUsedTips.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "MaxUsedTips";
            // 
            // MaxBottleNumber
            // 
            this.MaxBottleNumber.Location = new System.Drawing.Point(15, 106);
            this.MaxBottleNumber.Name = "MaxBottleNumber";
            this.MaxBottleNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxBottleNumber.Size = new System.Drawing.Size(112, 20);
            this.MaxBottleNumber.TabIndex = 16;
            this.MaxBottleNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "MaxBottleNumber";
            // 
            // ModesInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 206);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxUsedTips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxBottleNumber);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(157, 245);
            this.MinimumSize = new System.Drawing.Size(157, 245);
            this.Name = "ModesInput";
            this.Text = "ModesInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ModeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxUsedTips;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxBottleNumber;
        private System.Windows.Forms.Label label1;
    }
}