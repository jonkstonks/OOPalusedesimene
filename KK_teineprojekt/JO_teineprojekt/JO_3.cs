using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JO_teineprojekt
{
    public partial class JO_3 : Form
    {
        public Button JO_button3;

        public JO_3()
        {
            InitializeComponent();
            JO_listBox1.Sorted = JO_checkBox2.Checked;
        }

        private void JO_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            JO_button3.Enabled = true;

        }

        private void JO_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JO_button2_Click(object sender, EventArgs e)
        {
            string t = JO_textBox1.Text;
            int number = JO_listBox1.SelectedIndex;
            if (number == -1)
                JO_listBox1.Items.Add(t);
            else
            {
                JO_listBox1.Items.Insert(number, t);
                JO_listBox1.SelectedIndex = -1;

            }



            JO_textBox1.Text = "";
            JO_textBox1.Focus();

        }

        private void JO_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (JO_checkBox2.Checked)
                JO_checkBox2.Text = "Sorted";

            else
                JO_checkBox2.Text = "Unsorted";
            JO_listBox1.Sorted = JO_checkBox2.Checked;


        }

        private void JO_button4_Click(object sender, EventArgs e)
        {
            int number = JO_listBox1.SelectedIndex;
            if (number == -1)
            {
                MessageBox.Show("Valik puudub");
                return;


            }
            string t = JO_listBox1.Items[number].ToString();
            t = "Soovid kustutada:" + (char)(13) + t;
            DialogResult vastus = MessageBox.Show(t, "Hoiatus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
                JO_listBox1.Items.RemoveAt(number);
            else
                JO_listBox1.SelectedIndex = -1;



        }

        private void JO_button5_Click(object sender, EventArgs e)
        {
            int number = JO_listBox1.SelectedIndex;
            if (number == -1)
            {
                MessageBox.Show("Valik puudub");
                return;
            }
            JO_listBox1.Items[number] = JO_textBox1.Text;

        }
    }





}
