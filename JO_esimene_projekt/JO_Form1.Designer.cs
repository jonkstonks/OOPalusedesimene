namespace JO_esimene_projekt
{
    partial class JO_Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.JO_textBox1 = new System.Windows.Forms.TextBox();
            this.JO_label1 = new System.Windows.Forms.Label();
            this.JO_button1 = new System.Windows.Forms.Button();
            this.JO_label2 = new System.Windows.Forms.Label();
            this.JO_checkBox1 = new System.Windows.Forms.CheckBox();
            this.JO_frame1 = new System.Windows.Forms.GroupBox();
            this.JO_timer1 = new System.Windows.Forms.Timer(this.components);
            this.JO_label3 = new System.Windows.Forms.Label();
            this.JO_radioBtn1 = new System.Windows.Forms.RadioButton();
            this.JO_radioBtn2 = new System.Windows.Forms.RadioButton();
            this.JO_radioBtn3 = new System.Windows.Forms.RadioButton();
            this.JO_checkBox2 = new System.Windows.Forms.CheckBox();
            this.JO_frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // JO_textBox1
            // 
            this.JO_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JO_textBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.JO_textBox1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_textBox1.Location = new System.Drawing.Point(15, 43);
            this.JO_textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.JO_textBox1.Name = "JO_textBox1";
            this.JO_textBox1.Size = new System.Drawing.Size(375, 24);
            this.JO_textBox1.TabIndex = 1;
            this.JO_textBox1.UseWaitCursor = true;
            this.JO_textBox1.TextChanged += new System.EventHandler(this.JO_textBox1_TextChanged);
            // 
            // JO_label1
            // 
            this.JO_label1.AutoSize = true;
            this.JO_label1.BackColor = System.Drawing.Color.LightGray;
            this.JO_label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JO_label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JO_label1.Location = new System.Drawing.Point(511, 43);
            this.JO_label1.MinimumSize = new System.Drawing.Size(375, 31);
            this.JO_label1.Name = "JO_label1";
            this.JO_label1.Size = new System.Drawing.Size(375, 31);
            this.JO_label1.TabIndex = 2;
            this.JO_label1.UseMnemonic = false;
            this.JO_label1.Click += new System.EventHandler(this.JO_label1_Click);
            // 
            // JO_button1
            // 
            this.JO_button1.BackColor = System.Drawing.Color.YellowGreen;
            this.JO_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JO_button1.Location = new System.Drawing.Point(399, 43);
            this.JO_button1.Name = "JO_button1";
            this.JO_button1.Size = new System.Drawing.Size(106, 33);
            this.JO_button1.TabIndex = 3;
            this.JO_button1.Text = "-->";
            this.JO_button1.UseVisualStyleBackColor = false;
            this.JO_button1.Click += new System.EventHandler(this.JO_button1_Click);
            // 
            // JO_label2
            // 
            this.JO_label2.AutoSize = true;
            this.JO_label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.JO_label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JO_label2.Location = new System.Drawing.Point(511, 85);
            this.JO_label2.MinimumSize = new System.Drawing.Size(375, 31);
            this.JO_label2.Name = "JO_label2";
            this.JO_label2.Size = new System.Drawing.Size(375, 31);
            this.JO_label2.TabIndex = 4;
            this.JO_label2.Click += new System.EventHandler(this.JO_label2_Click);
            // 
            // JO_checkBox1
            // 
            this.JO_checkBox1.AutoSize = true;
            this.JO_checkBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.JO_checkBox1.Location = new System.Drawing.Point(511, 119);
            this.JO_checkBox1.Name = "JO_checkBox1";
            this.JO_checkBox1.Size = new System.Drawing.Size(211, 27);
            this.JO_checkBox1.TabIndex = 5;
            this.JO_checkBox1.Text = "V2ikesed t2hed";
            this.JO_checkBox1.UseVisualStyleBackColor = false;
            this.JO_checkBox1.CheckedChanged += new System.EventHandler(this.JO_checkBox1_CheckedChanged);
            // 
            // JO_frame1
            // 
            this.JO_frame1.BackColor = System.Drawing.Color.Thistle;
            this.JO_frame1.Controls.Add(this.JO_checkBox2);
            this.JO_frame1.Controls.Add(this.JO_radioBtn3);
            this.JO_frame1.Controls.Add(this.JO_radioBtn2);
            this.JO_frame1.Controls.Add(this.JO_radioBtn1);
            this.JO_frame1.Controls.Add(this.JO_label3);
            this.JO_frame1.Location = new System.Drawing.Point(511, 168);
            this.JO_frame1.Name = "JO_frame1";
            this.JO_frame1.Size = new System.Drawing.Size(375, 276);
            this.JO_frame1.TabIndex = 6;
            this.JO_frame1.TabStop = false;
            this.JO_frame1.Text = "Juhhuu!";
            // 
            // JO_timer1
            // 
            this.JO_timer1.Enabled = true;
            this.JO_timer1.Interval = 1000;
            this.JO_timer1.Tick += new System.EventHandler(this.JO_timer1_Tick);
            // 
            // JO_label3
            // 
            this.JO_label3.BackColor = System.Drawing.Color.Orchid;
            this.JO_label3.Location = new System.Drawing.Point(6, 27);
            this.JO_label3.Name = "JO_label3";
            this.JO_label3.Size = new System.Drawing.Size(363, 31);
            this.JO_label3.TabIndex = 0;
            this.JO_label3.Text = "label1";
            this.JO_label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JO_radioBtn1
            // 
            this.JO_radioBtn1.AutoSize = true;
            this.JO_radioBtn1.Location = new System.Drawing.Point(6, 61);
            this.JO_radioBtn1.Name = "JO_radioBtn1";
            this.JO_radioBtn1.Size = new System.Drawing.Size(275, 27);
            this.JO_radioBtn1.TabIndex = 1;
            this.JO_radioBtn1.TabStop = true;
            this.JO_radioBtn1.Text = "Kuup2ev ja kellaaeg";
            this.JO_radioBtn1.UseVisualStyleBackColor = true;
            // 
            // JO_radioBtn2
            // 
            this.JO_radioBtn2.AutoSize = true;
            this.JO_radioBtn2.Location = new System.Drawing.Point(6, 94);
            this.JO_radioBtn2.Name = "JO_radioBtn2";
            this.JO_radioBtn2.Size = new System.Drawing.Size(119, 27);
            this.JO_radioBtn2.TabIndex = 2;
            this.JO_radioBtn2.TabStop = true;
            this.JO_radioBtn2.Text = "Kuup2ev";
            this.JO_radioBtn2.UseVisualStyleBackColor = true;
            // 
            // JO_radioBtn3
            // 
            this.JO_radioBtn3.AutoSize = true;
            this.JO_radioBtn3.Location = new System.Drawing.Point(6, 127);
            this.JO_radioBtn3.Name = "JO_radioBtn3";
            this.JO_radioBtn3.Size = new System.Drawing.Size(132, 27);
            this.JO_radioBtn3.TabIndex = 3;
            this.JO_radioBtn3.TabStop = true;
            this.JO_radioBtn3.Text = "Kellaaeg";
            this.JO_radioBtn3.UseVisualStyleBackColor = true;
            // 
            // JO_checkBox2
            // 
            this.JO_checkBox2.AutoSize = true;
            this.JO_checkBox2.Location = new System.Drawing.Point(14, 228);
            this.JO_checkBox2.Name = "JO_checkBox2";
            this.JO_checkBox2.Size = new System.Drawing.Size(146, 27);
            this.JO_checkBox2.TabIndex = 4;
            this.JO_checkBox2.Text = "checkBox1";
            this.JO_checkBox2.UseVisualStyleBackColor = true;
            this.JO_checkBox2.CheckedChanged += new System.EventHandler(this.JO_checkBox2_CheckedChanged);
            // 
            // JO_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 474);
            this.Controls.Add(this.JO_frame1);
            this.Controls.Add(this.JO_checkBox1);
            this.Controls.Add(this.JO_label2);
            this.Controls.Add(this.JO_button1);
            this.Controls.Add(this.JO_label1);
            this.Controls.Add(this.JO_textBox1);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "JO_Form1";
            this.Text = "0801_2026";
            this.Load += new System.EventHandler(this.JO_Form1_Load);
            this.JO_frame1.ResumeLayout(false);
            this.JO_frame1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox JO_textBox1;
        private System.Windows.Forms.Label JO_label1;
        private System.Windows.Forms.Button JO_button1;
        private System.Windows.Forms.Label JO_label2;
        private System.Windows.Forms.CheckBox JO_checkBox1;
        private System.Windows.Forms.GroupBox JO_frame1;
        private System.Windows.Forms.Label JO_label3;
        private System.Windows.Forms.Timer JO_timer1;
        private System.Windows.Forms.RadioButton JO_radioBtn1;
        private System.Windows.Forms.RadioButton JO_radioBtn2;
        private System.Windows.Forms.RadioButton JO_radioBtn3;
        private System.Windows.Forms.CheckBox JO_checkBox2;
    }
}

