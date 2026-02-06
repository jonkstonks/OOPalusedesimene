namespace JO_teineprojekt
{
    partial class JO_3
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
            this.JO_button2 = new System.Windows.Forms.Button();
            this.JO_textBox1 = new System.Windows.Forms.TextBox();
            this.JO_listBox1 = new System.Windows.Forms.ListBox();
            this.JO_checkBox2 = new System.Windows.Forms.CheckBox();
            this.JO_button4 = new System.Windows.Forms.Button();
            this.JO_button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JO_button2
            // 
            this.JO_button2.Location = new System.Drawing.Point(295, 36);
            this.JO_button2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.JO_button2.Name = "JO_button2";
            this.JO_button2.Size = new System.Drawing.Size(268, 41);
            this.JO_button2.TabIndex = 1;
            this.JO_button2.Text = "--->";
            this.JO_button2.UseVisualStyleBackColor = true;
            this.JO_button2.Click += new System.EventHandler(this.JO_button2_Click);
            // 
            // JO_textBox1
            // 
            this.JO_textBox1.Location = new System.Drawing.Point(18, 33);
            this.JO_textBox1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.JO_textBox1.Name = "JO_textBox1";
            this.JO_textBox1.Size = new System.Drawing.Size(239, 44);
            this.JO_textBox1.TabIndex = 2;
            this.JO_textBox1.Text = "n2idis tekst";
            // 
            // JO_listBox1
            // 
            this.JO_listBox1.FormattingEnabled = true;
            this.JO_listBox1.ItemHeight = 36;
            this.JO_listBox1.Location = new System.Drawing.Point(601, 33);
            this.JO_listBox1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.JO_listBox1.Name = "JO_listBox1";
            this.JO_listBox1.Size = new System.Drawing.Size(288, 256);
            this.JO_listBox1.TabIndex = 3;
            this.JO_listBox1.SelectedIndexChanged += new System.EventHandler(this.JO_listBox1_SelectedIndexChanged);
            // 
            // JO_checkBox2
            // 
            this.JO_checkBox2.AutoSize = true;
            this.JO_checkBox2.Checked = true;
            this.JO_checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JO_checkBox2.Location = new System.Drawing.Point(601, 310);
            this.JO_checkBox2.Name = "JO_checkBox2";
            this.JO_checkBox2.Size = new System.Drawing.Size(186, 40);
            this.JO_checkBox2.TabIndex = 4;
            this.JO_checkBox2.Text = "Unsorted";
            this.JO_checkBox2.UseVisualStyleBackColor = true;
            this.JO_checkBox2.CheckedChanged += new System.EventHandler(this.JO_checkBox2_CheckedChanged);
            // 
            // JO_button4
            // 
            this.JO_button4.Location = new System.Drawing.Point(295, 93);
            this.JO_button4.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.JO_button4.Name = "JO_button4";
            this.JO_button4.Size = new System.Drawing.Size(268, 41);
            this.JO_button4.TabIndex = 5;
            this.JO_button4.Text = "Delete";
            this.JO_button4.UseVisualStyleBackColor = true;
            this.JO_button4.Click += new System.EventHandler(this.JO_button4_Click);
            // 
            // JO_button5
            // 
            this.JO_button5.Location = new System.Drawing.Point(295, 150);
            this.JO_button5.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.JO_button5.Name = "JO_button5";
            this.JO_button5.Size = new System.Drawing.Size(268, 41);
            this.JO_button5.TabIndex = 6;
            this.JO_button5.Text = "Update";
            this.JO_button5.UseVisualStyleBackColor = true;
            this.JO_button5.Click += new System.EventHandler(this.JO_button5_Click);
            // 
            // JO_3
            // 
            this.AcceptButton = this.JO_button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 367);
            this.Controls.Add(this.JO_button5);
            this.Controls.Add(this.JO_button4);
            this.Controls.Add(this.JO_checkBox2);
            this.Controls.Add(this.JO_listBox1);
            this.Controls.Add(this.JO_textBox1);
            this.Controls.Add(this.JO_button2);
            this.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "JO_3";
            this.Text = "JO_3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JO_3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button JO_button2;
        private System.Windows.Forms.TextBox JO_textBox1;
        private System.Windows.Forms.ListBox JO_listBox1;
        private System.Windows.Forms.CheckBox JO_checkBox2;
        private System.Windows.Forms.Button JO_button4;
        private System.Windows.Forms.Button JO_button5;
    }
}