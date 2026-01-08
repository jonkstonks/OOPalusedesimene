using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JO_esimene_projekt
{
    public partial class JO_Form1 : Form
    {
        public JO_Form1()
        {
            InitializeComponent();
        }

        private void JO_textBox1_TextChanged(object sender, EventArgs e)
        {
            JO_label2.Text = JO_textBox1.Text;        
        }

        private void JO_label1_Click(object sender, EventArgs e)
        {

        }

        private void JO_Form1_Load(object sender, EventArgs e)
        {

        }

        private void JO_button1_Click(object sender, EventArgs e)
        {
            JO_label1.Text = JO_textBox1.Text;
        }

        private void JO_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string t = JO_label3.Text;
            
            if (JO_checkBox1.Checked)
            {
                JO_label3.Text = t.ToUpper();
                JO_checkBox1.Text = "Suured t2hed";
            }
            else
            {
                JO_label3.Text = t.ToLower();
                JO_checkBox1.Text = "V2ikesed t2hed";
            }

            /*
            if (JO_checkBox1.Checked)
            {
                JO_checkBox1.Text = "Suured t2hed";
            }
            else
            {
                JO_checkBox1.Text = "V2ikesed t2hed";
            }
            */
            JO_textBox1_TextChanged(null, null);
        }

        private void JO_label2_Click(object sender, EventArgs e)
        {
            JO_textBox1.Text = JO_label1.Text;
        }

        private void JO_timer1_Tick(object sender, EventArgs e)
        {

            if (JO_radioBtn1.Checked)
                JO_label3.Text = DateTime.Now.ToString();
            else if (JO_radioBtn2.Checked)
                JO_label3.Text = DateTime.Now.ToLongDateString();
            else if (JO_radioBtn3.Checked)
                JO_label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void JO_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Vaja lylitada timer sisse v6i v2lja 
        }
    }
}
