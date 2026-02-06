namespace JO_teineprojekt
{
    partial class JO_formmain
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
            this.JO_button1 = new System.Windows.Forms.Button();
            this.JO_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JO_button1
            // 
            this.JO_button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.JO_button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JO_button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.JO_button1.Location = new System.Drawing.Point(92, 57);
            this.JO_button1.Name = "JO_button1";
            this.JO_button1.Size = new System.Drawing.Size(388, 85);
            this.JO_button1.TabIndex = 0;
            this.JO_button1.Text = "22.01.2026";
            this.JO_button1.UseVisualStyleBackColor = false;
            this.JO_button1.Click += new System.EventHandler(this.JO_button1_Click);
            // 
            // JO_button2
            // 
            this.JO_button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.JO_button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JO_button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.JO_button2.Location = new System.Drawing.Point(92, 164);
            this.JO_button2.Name = "JO_button2";
            this.JO_button2.Size = new System.Drawing.Size(388, 85);
            this.JO_button2.TabIndex = 1;
            this.JO_button2.Text = "06.02.2026";
            this.JO_button2.UseVisualStyleBackColor = false;
            this.JO_button2.Click += new System.EventHandler(this.JO_button2_Click);
            // 
            // JO_formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 812);
            this.Controls.Add(this.JO_button2);
            this.Controls.Add(this.JO_button1);
            this.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "JO_formmain";
            this.Text = "JO_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JO_button1;
        private System.Windows.Forms.Button JO_button2;
    }
}

